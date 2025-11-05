using System;
using System.Collections.Generic;

namespace Buildflow.Infrastructure.Entities;

public partial class TicketComment
{
    public int CommentId { get; set; }

    public int? TicketId { get; set; }

    public string? Comment { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedByType { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual Ticket? Ticket { get; set; }
}
