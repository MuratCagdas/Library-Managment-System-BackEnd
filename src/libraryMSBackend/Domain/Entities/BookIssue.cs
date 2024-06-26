﻿using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class BookIssue : Entity<Guid>
{
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public Guid LibraryStaffId { get; set; }
    public DateTime ReturnDate { get; set; }

    public BookIssue()
    {
        // ReturnDate'i şu anki tarihin bir ay sonrası olarak varsayılan olarak ayarladık
        //ReturnDate = DateTime.Now.AddMonths(1);
        FineDues = new HashSet<FineDue>();
    }
    public virtual Book Book { get; set; }
    public virtual Member Member { get; set; }
    public virtual LibraryStaff LibraryStaff { get; set; }

    public virtual ICollection<FineDue> FineDues { get; set; }

}
