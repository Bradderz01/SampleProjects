using App1.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModel
{
    public class MainPageModel : ViewModelBase
    {
        private ObservableCollection<ITrack> _trackList = new ObservableCollection<ITrack>();

        /// <summary>
        /// Sets and gets the TrackList property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// This property's value is broadcasted by the MessengerInstance when it changes.
        /// </summary>
        public ObservableCollection<ITrack> TrackList
        {
            get
            {
                return _trackList;
            }
            set
            {
                Set(() => TrackList, ref _trackList, value, true);
            }
        }

        public MainPageModel()
        {
            ObservableCollection<ITrack> newTracks = new ObservableCollection<ITrack>();
            ITrack trk1 = new Track() { Segment = 1, Name = "Trk1", Activity = Activity.Activity1 };
            ITrack trk2 = new Track() { Segment = 2, Name = "Trk2", Activity = Activity.Activity2 };
            ITrack trk3 = new Track() { Segment = 3, Name = "Trk3", Activity = Activity.Activity3 };
            newTracks.Add(trk1);
            newTracks.Add(trk2);
            newTracks.Add(trk3);

            TrackList = newTracks;
        }
    }
}
