using Experity_Assessment.Commands;
using Experity_Assessment.Interfaces;
using Experity_Assessment.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Experity_Assessment.ViewModels
{
    public class EventViewModel : ViewModelBase
    {
        public ICommand PrintCommand { get; }

        private readonly IPrintService _printService;
        public EventViewModel(IPrintService printService)
        {
            _printService = printService;
            _events = new ObservableCollection<EventModel>()
            {
                new EventModel(){ EventType = "Register"},
                new EventModel(){ EventType = "Diagnose"}
            };

            PrintCommand = new PrintCommand(_ => ExecutePrintNumber(SelectedEventType), this);
        }

        private void ExecutePrintNumber(EventModel type)
        {
            ReturnLists = _printService.GetPrintNumber(1, 100, type.EventType);
        }


        private ObservableCollection<EventModel> _events;
        public ObservableCollection<EventModel> Events
        {
            get { return _events; }
            set { _events = value; }
        }


        private EventModel _selectedEventType;
        public EventModel SelectedEventType
        {
            get { return _selectedEventType; }
            set
            {
                _selectedEventType = value;
                OnPropertyChanged(nameof(SelectedEventType));
            }
        }

        private List<string> _returnLists;
        public List<string> ReturnLists
        {
            get { return _returnLists; }
            set
            {
                _returnLists = value;
                OnPropertyChanged(nameof(ReturnLists));
            }
        }

    }
}
