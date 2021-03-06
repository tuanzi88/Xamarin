﻿using Microsoft.WindowsAzure.Mobile.Service;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskyMobileService.DataObjects
{
    public class Message : EntityData
    {
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }

        //Shuran: Use of foreignkey and inverseproperty
        //Reference: http://www.entityframeworktutorial.net/code-first/inverseproperty-dataannotations-attribute-in-code-first.aspx
        [ForeignKey("SenderID")]
        public virtual User Sender { get; set; }
        [ForeignKey("ReceiverID")]
        public virtual User Receiver { get; set; }

        public string Content { get; set; }
        public bool IsRead { get; set; }
        public int Order { get; set; }
    }
}
