using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }        //訂單建立時間

        public string UserId { get; set; }             //付款者ID
        public string UserName { get; set; }           //付款者帳號

        public string ReceiverName { get; set; }       //收貨者姓名
        public string ReceiverAdress { get; set; }     //收貨者地址
        public string ReceiverPhone { get; set; }      //收貨者電話

        public int Total { get; set; }                 //訂單總額
        public List<OrderItem> OrderItem { get; set; } //訂單內容
        public bool isPaid { get; set; }               //付款狀態
    }
}
