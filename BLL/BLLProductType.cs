using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class BLLProductType
    {
        string _productTypeBLL;
        //ata local value sudhu ai class e use hobe or e akta prop banalam niche jeta onno class theke access hobe ata subidhe maintain korte
        public string ProductTypeBLL { get => _productTypeBLL; set => _productTypeBLL = value; }//aita onno class e use hobe dekh public o ata 2 to jinis e aktai veriable ke point korche

        public int BllInsertProductType()
        {
            DALProductType productType = new DALProductType();
            productType.ProductType = _productTypeBLL;
            //Arom nam dile nijei confuse hoye jabi konta ki
            int roeEffected=productType.InsertProductType();
            return roeEffected;
            //done bujte parli ki changes korlam ui teo same kaj hobe
        }
    }
}
