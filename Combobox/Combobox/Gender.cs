using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Globalization;

namespace Combobox
{
   public class Gender:INotifyPropertyChanged
    {

        /*  private string male;
          private string female;
          private string sitem;
         public string Male
          {
              get
              {
                  return male;
                  onPropertyChanged("Male");
              }
              set
              {
                  if (male != value)
                  {
                      male = value;
                  }
              }
          }
          public string Female
          {
              get
              {
                  return female;
                  onPropertyChanged("Female");

              }
              set
              {
                  if (female != value)
                  {
                      female = value;
                  }
              }
          }*/
        public string sitem { get; set; }
         
        private string gendervalue;
        public string Gendervalue
        {
            get
            {
                return gendervalue;
            }
            set
            {
                if(gendervalue!=null)
                {
                    gendervalue = value;
                    onPropertyChanged("Gendervalue");
                }
            }
        }
        private void onPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
       
    
}
}
