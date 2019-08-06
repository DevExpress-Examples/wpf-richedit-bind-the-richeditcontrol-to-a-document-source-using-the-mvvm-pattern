using DXRichEditMVVM.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXRichEditMVVM.ViewModel
{
    public class ViewModel
    {
        #region #ViewModel
        MyModel carsModel;
        Car car;

        public virtual object DataBaseDocumentSource { get; set; }

        public ViewModel()
        {
            //Load the database
            carsModel = new MyModel();
            carsModel.Cars.Load();
            //Use the rtf content from the first database entry
            //and pass it to the DataBaseDocumentSource property
            car = carsModel.Cars.Local[0];
            DataBaseDocumentSource = car.RtfContent;
        }
        #endregion #ViewModel

        #region #UpdateRtfText
        bool modified;
        public void UpdateModified(bool Modified)
        {
            this.modified = Modified;
        }
        #endregion #UpdateRtfText

        #region #SaveCommand
        public void Save(string rtfText)
        {
            //Access the table entry by its model name
            Car newCar = carsModel.Cars.Where(d => d.Model == "SL500 Roadster").First();

            //Set its Rtf property to the current content
            newCar.RtfContent = rtfText;
            carsModel.SaveChanges();

            //Reset the current content
            modified = false;

        }
        public bool CanSave(string rtfText)
        {
            return modified != false;
        }
        #endregion #SaveCommand
    }
}
