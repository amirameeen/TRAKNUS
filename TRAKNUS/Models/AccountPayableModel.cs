using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TRAKNUS.Models
{
    public class AccountPayableModel
    {
        public string company_code { get; set; }
        public long document_number { get; set; }
        public int fiscal_year { get; set; }
        public int number_of_line_item { get; set; }
        public DateTime document_date { get; set; }
        public DateTime posting_date { get; set; }
        public int fiscal_period { get; set; }
        public string reference_document { get; set; }
        public string document_header_text { get; set; }
        public string document_type { get; set; }
        public string currency { get; set; }
        public float exchange_rate { get; set; }
        public DateTime transaction_date { get; set; }
        public string transaction_code { get; set; }
        public string dc_indicatior { get; set; }
        public string account_type { get; set; }
        public string special_gl_indicator { get; set; }
        public string target_special_gl_indicator { get; set; }//null
        public string gl_account { get; set; }//null
        public long gl_account_number { get; set; }
        public float amount_in_document { get; set; }
        public long amount_in_local_currency { get; set; }
        public string tax_code { get; set; }//null
        public string business_area { get; set; }
        public string cost_center { get; set; }
        public string profit_center { get; set; }
        public DateTime value_date { get; set; }
        public string term_of_payment { get; set; }
        public int day { get; set; }
        public string assigment { get; set; }
        public string keterangan { get; set; }
        public long invoice_reference_dan_tahun { get; set; }
        public int payment_reference { get; set; }
        public int purchasing_order_number { get; set; }//null
        public int purchasing_order_item { get; set; }
        public int seles_order_number { get; set; }//null
        public int sales_order_item { get; set; }
        public int billing { get; set; }//null
        public int product { get; set; }//null
        public string bstkd { get; set; }//null
        public string salesman { get; set; }
        public string nama_salesman { get; set; }//null
        public string leasing { get; set; }
        public string nama_leasing { get; set; }//null
        public int nilai_bill_docur { get; set; }//null
        public int nilai_bill_locur { get; set; }//null
    }
}