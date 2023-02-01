using System;
using System.ComponentModel;
using NationalInstruments.NetworkVariable;

namespace Datalogging
{
    public class OPC_DA_Read
    {
        private NetworkVariableSubscriber<double> _subscriber;

        public delegate void updateValue(double value);
        public event updateValue Value;

        public delegate void updateQuality(string value);
        public event updateQuality Quality;

        public delegate void updateTimeStamp(string value);
        public event updateTimeStamp Timestamp;

        public delegate void updateConStatus(string status);
        public event updateConStatus Constatus;

        private void CreateSubscriber(string TagAdress)
        {
            _subscriber = new NetworkVariableSubscriber<double>(TagAdress);
            _subscriber.PropertyChanged += new PropertyChangedEventHandler(OnPropertyChanged);
            _subscriber.DataUpdated += new EventHandler<DataUpdatedEventArgs<double>>(OnDataUpdated);
        }
        private void OnDataUpdated(object sender, DataUpdatedEventArgs<double> e)
        {
            if (e.Data.HasTimeStamp)
            {
                Timestamp(e.Data.TimeStamp.ToLocalTime().ToString());
            }
            if (e.Data.HasQuality)
            {
                Quality(e.Data.Quality.ToString());
            }
            if (e.Data.HasValue)
            {
                Value(e.Data.GetValue());
            }
        }
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ConnectionStatus")
            {
                Constatus(_subscriber.ConnectionStatus.ToString());
            }
        }
        public void Connect(string TagAdress)
        {
            if (_subscriber == null)
            {
                CreateSubscriber(TagAdress);
                _subscriber.Connect();
            }

        }
        public void Disconnect()
        {
            if (_subscriber != null)
            {
                _subscriber.Disconnect();
                _subscriber = null;
            }
        }
    }
}
