using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Util;
using static Android.App.DatePickerDialog;

namespace App11
{
    public class DatePickerFragment : DialogFragment, IOnDateSetListener
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return base.OnCreateView(inflater, container, savedInstanceState);
        }
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {

            Calendar c = Calendar.Instance;
            return new DatePickerDialog(Activity, Android.App.AlertDialog.ThemeDeviceDefaultLight,
               this, c.Get(CalendarField.Year), c.Get(CalendarField.Month), c
                .Get(CalendarField.DayOfMonth));
        }

        public void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {
            throw new NotImplementedException();
        }
    }
}