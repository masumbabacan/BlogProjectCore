﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Notification : IEntity
    {
        [Key]
        public int NotificationId { get; set; }
        public string NotificationType { get; set; }
        public string NotificationTyeSymbol { get; set; }
        public string NotificationDetails { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool NotificationStatus { get; set; }


    }
}
