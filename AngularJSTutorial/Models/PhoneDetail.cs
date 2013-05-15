using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSTutorial.Models
{
    public class PhoneDetail
    {
        public string additionalFeatures { get; set; }
        public AndroidDetail android { get; set; }
        public string[] availability { get; set; }
        public BatteryDetail battery { get; set; }
        public CameraDetail camera { get; set; }
        public ConnectivityDetail connectivity { get; set; }
        public string description { get; set; }
        public DisplayDetail display { get; set; }
        public HardwareDetail hardware { get; set; }
        public string id { get; set; }
        public string[] images { get; set; }
        public string name { get; set; }
        public SizeAndWeightDetail sizeAndWeight { get; set; }
        public StorageDetail storage { get; set; }

        public class AndroidDetail
        {
            public string os { get; set; }
            public string ui { get; set; }
        }

        public class BatteryDetail
        {
            public string type { get; set; }
            public string talkTime { get; set; }
            public string standbyTime { get; set; }
        }

        public class CameraDetail
        {
            public string[] features { get; set; }
            public string primary { get; set; }
        }

        public class ConnectivityDetail
        {
            public string bluetooth { get; set; }
            public string cell { get; set; }
            public bool gps { get; set; }
            public bool infrared { get; set; }
            public string wifi { get; set; }
        }

        public class DisplayDetail
        {
            public string screenResolution { get; set; }
            public string screenSize { get; set; }
            public bool touchScreen { get; set; }
        }

        public class HardwareDetail
        {
            public bool accelerometer { get; set; }
            public string audioJack { get; set; }
            public string cpu { get; set; }
            public bool fmRadio { get; set; }
            public bool physicalKeyboard { get; set; }
            public string usb { get; set; }
        }

        public class SizeAndWeightDetail
        {
            public string[] dimensions { get; set; }
            public string weight { get; set; }
        }

        public class StorageDetail
        {
            public string flash { get; set; }
            public string ram { get; set; }
        }
    }
}