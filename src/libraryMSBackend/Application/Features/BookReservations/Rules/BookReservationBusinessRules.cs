using Application.Features.BookReservations.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;
using Domain.Enums;

namespace Application.Features.BookReservations.Rules;

public class BookReservationBusinessRules : BaseBusinessRules
{
    private readonly IBookReservationRepository _bookReservationRepository;
    private readonly ILocalizationService _localizationService;
    private readonly IBookRepository _bookRepository;

    public BookReservationBusinessRules(IBookReservationRepository bookReservationRepository, ILocalizationService localizationService, IBookRepository bookRepository)
    {
        _bookReservationRepository = bookReservationRepository;
        _localizationService = localizationService;
        _bookRepository = bookRepository;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, BookReservationsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task BookReservationShouldExistWhenSelected(BookReservation? bookReservation)
    {
        if (bookReservation == null)
            await throwBusinessException(BookReservationsBusinessMessages.BookReservationNotExists);
    }

    public async Task BookReservationIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        BookReservation? bookReservation = await _bookReservationRepository.GetAsync(
            predicate: br => br.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await BookReservationShouldExistWhenSelected(bookReservation);
    }
    public async Task EnsureBookCanBeReserved(Guid bookId)
    {
        // Kitab� al�n
        var book = await _bookRepository.GetByIdAsync(bookId);

        // E�er kitap rezerve edilmi�se, yeni rezervasyona izin verme
        var existingReservation = _bookReservationRepository.Table
            .FirstOrDefault(br => br.BookId == bookId);

        if (existingReservation != null)
        {
            throw new Exception($"This book is already reserved by another user.");
        }

        // E�er kitap �d�n� al�nm��sa, rezervasyon yap�labilir
        if (book.Status == BookStatus.Borrowed)
        {
            return; // Rezervasyon yap�labilir
        }

        // Di�er durumlar i�in herhangi bir engel yoktur
    }

    //todo: BusinessRules -> Rezervasyon S�resi: Bir kullan�c�n�n bir kitab� ne kadar s�reyle rezerve edebilece�i belirlenmelidir. �rne�in, her kullan�c�ya belirli bir s�re i�in rezervasyon hakk� verilebilir, bu s�re genellikle birka� g�n ile bir hafta aras�nda olabilir.

    //todo: BusinessRules -> Rezervasyon �nceli�i: Birden fazla kullan�c�n�n ayn� kitab� rezerve etmek istemesi durumunda, rezervasyon �nceli�i belirli kurallara g�re belirlenebilir. �rne�in, rezervasyonu ilk yapan kullan�c�ya �ncelik verilebilir veya daha �nce rezervasyon yapmam�� kullan�c�lara �ncelik tan�nabilir.

    //todo: BusinessRules -> Rezervasyon �ptali: Kullan�c�lar�n rezervasyonlar�n� iptal edebilme hakk� olmal�d�r. Ancak, iptal edilen rezervasyonlar�n belirli bir s�re i�inde (�rne�in, 24 saat) geri al�nmas� gerekebilir, aksi takdirde kitap ba�ka bir kullan�c�ya rezerve edilebilir.

    //todo: BusinessRules -> Rezervasyon Limiti: Bir kullan�c�n�n ayn� anda ka� kitap rezerve edebilece�i s�n�rlanabilir. Bu, ayn� zamanda birden fazla kullan�c�n�n k�t�phanenin belirli kitaplar�n� ayn� anda rezerve etmesini �nleyebilir.

    //todo: BusinessRules -> Rezervasyon Bildirimi: Kullan�c�lara rezervasyonlar�n�n onayland��� veya reddedildi�i konusunda bildirimler g�nderilmelidir. Ayr�ca, rezervasyonun sona ermesine yak�n kullan�c�lara hat�rlat�c� bildirimler g�ndermek de yararl� olabilir.
}