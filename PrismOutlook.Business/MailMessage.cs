﻿using System;
using System.Collections.ObjectModel;

namespace PrismOutlook.Business
{
    public class MailMessage : BusinessBase
    {
        public int Id { get; set; }

        private string _from;
        public string From
        {
            get => _from;
            set => SetProperty(ref _from, value);
        }

        private string _subject;
        public string Subject
        {
            get => _subject;
            set => SetProperty(ref _subject, value);
        }

        private ObservableCollection<string> _to = new ObservableCollection<string>();
        public ObservableCollection<string> To
        {
            get => _to;
            set => SetProperty(ref _to, value);
        }

        private ObservableCollection<string> _cc = new ObservableCollection<string>();
        public ObservableCollection<string> CC
        {
            get => _cc;
            set => SetProperty(ref _cc, value);
        }

        private string _body;
        public string Body
        {
            get => _body;
            set => SetProperty(ref _body, value);
        }

        private DateTime _dateSent;
        public DateTime DateSent
        {
            get => _dateSent;
            set => SetProperty(ref _dateSent, value);
        }

        public MailMessage()
        {
            Id = new Random().Next(10, 6000);
        }
    }
}
