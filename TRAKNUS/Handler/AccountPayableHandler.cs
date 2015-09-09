using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using TRAKNUS.Models;

namespace TRAKNUS.Handler
{
    public class AccountPayableHandler
    {
        public List<AccountPayableModel> readText(System.Web.HttpContextBase context)
        {

            List<AccountPayableModel> apm = new List<AccountPayableModel>();
            string fileName = "D:/.Data SAP/20150907_TRANSAKSIAP_A000_145739.txt";
            var baca = System.IO.File.ReadAllLines(fileName).ToList();

            baca.RemoveAt(0);
            int count = 1;
            foreach (var car in baca)
            {
                //List<string> data = car.Split('±').ToList();
                //foreach(var ap in data)
                //{
                
                if (!string.IsNullOrEmpty(car))
                {

                    AccountPayableModel AP = new AccountPayableModel();
                    AP.id_ap = count;
                    AP.company_code = car.Split('|')[0];
                    AP.document_number = Convert.ToInt64(car.Split('|')[1]);
                    AP.fiscal_year = Convert.ToInt32(car.Split('|')[2]);
                    AP.number_of_line_item = Convert.ToInt32(car.Split('|')[3]);
                    AP.document_date = car.Split('|')[4];
                    AP.posting_date = car.Split('|')[5];
                    AP.fiscal_period = Convert.ToInt32(car.Split('|')[6]);
                    AP.reference_document = car.Split('|')[7];
                    AP.document_header_text = car.Split('|')[8];
                    AP.document_type = car.Split('|')[9];
                    AP.currency = car.Split('|')[10];
                    AP.exchange_rate = Convert.ToDouble(car.Split('|')[11]);
                    AP.transaction_date = car.Split('|')[12];
                    AP.transaction_code = car.Split('|')[13];
                    AP.dc_indicatior = car.Split('|')[14];
                    AP.account_type = car.Split('|')[15];
                    AP.special_gl_indicator = car.Split('|')[16];
                    //skip 2
                    AP.gl_account_number = Convert.ToInt64(car.Split('|')[19]);
                    AP.amount_in_document = float.Parse(car.Split('|')[20], CultureInfo.InvariantCulture.NumberFormat);
                    AP.amount_in_local_currency = Convert.ToInt64(car.Split('|')[21]);
                    AP.tax_code = car.Split('|')[22];
                    AP.business_area = car.Split('|')[23];
                    //skip 2
                    AP.value_date = car.Split('|')[26];
                    AP.term_of_payment = car.Split('|')[27];
                    AP.day = Convert.ToInt32(car.Split('|')[28]);
                    AP.assigment = car.Split('|')[29];
                    AP.keterangan = car.Split('|')[30];
                    AP.invoice_reference_dan_tahun = car.Split('|')[31];
                    AP.payment_reference = car.Split('|')[32];
                    //skip
                    AP.purchasing_order_item = Convert.ToInt32(car.Split('|')[34]);
                    //skip
                    AP.sales_order_item = Convert.ToInt32(car.Split('|')[36]);
                    //skip 3
                    AP.salesman = Convert.ToInt32(car.Split('|')[40]);
                    //skip
                    AP.leasing = Convert.ToInt32(car.Split('|')[42]);
                    //skip 3
                    apm.Add(AP);
                    count++;
                }
                // }

            }
            return apm;
        }
    }
}