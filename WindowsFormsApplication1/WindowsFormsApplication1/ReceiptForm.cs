using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltraShopBd.DataAccess;
using UltraShopBd.Entites;

namespace WindowsFormsApplication1
{
    public partial class ReceiptForm : Form
    {
        
           
            Login userInfo = new Login();
           
        PendingDelivery left = new PendingDelivery();
        PendingDeliveryDA leftDA = new PendingDeliveryDA();
        List<PendingDelivery> listItem = new List<PendingDelivery>();
        List<PendingDelivery> PrintlistItem = new List<PendingDelivery>();
        Dictionary<string,int > orderStatusID = new Dictionary<string,int>();
        string devideDiscription = "";
        int flag = 0;
        public ReceiptForm()
        {
            InitializeComponent();
            FillOrderStatus();
            
            
        
        }

        public void GetUserData(Login user)
        {
            userInfo = user;
            
            

        }
        private void FillOrderStatus()
        {

            List<PendingDelivery> pa = new List<PendingDelivery>();

             pa=   leftDA.GetOrderStatus("order_status");
            foreach (PendingDelivery add in pa)
            {
                orderStatusID[add.order_status] = add.order_status_id;
               confirmationComboBox.Items.Add(add.order_status);
            }
        }

        public void PrintEnvelope()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printEnvelope_PrintPage);
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();


            }

        }


        void printEnvelope_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            List<string> Line = new List<string>();

            Graphics formGraphics = e.Graphics;

           left.address = left.address.Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty);
           Line = FormatMe(left.address , 50);
           string address = "";

           for (int i = Line.Count - 1; i >= 0; i--)
           {
               address += Line[i] + "\n";

           }

           
           string city = "City : " + left.cityName+"\n";
           string phone = "Mobile : " + left.phoneNumber+"\n";

            string drawString =address+city+phone +left.customerName+"\n"+ "To                                                     "+" ["+ left.orderID+"]";
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 12);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            float x = 480f;
            float y = 250f;
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat(StringFormatFlags.DirectionVertical);
            formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();


        }


        public void PrintRecipt()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            DialogResult result = printDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                printDocument.Print();


            }

        }
      

        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Graphics graphic = e.Graphics;
            //Font font = new Font("Courier New ", 12);

            //float fontHeight = font.GetHeight();
            //int startX = 10;
            //int startY = 10;
            //int offset = 40;

            //graphic.DrawString("Well Come To Ultra shop BD",new Font("Courier New ", 12),new SolidBrush(Color.Black),startX,startY);

            List<string> Line = new List<string>();


            Graphics graphics = e.Graphics;
            Font font1 = new Font("Arial", 14);
            Font font2 = new Font("Courier New", 12);
            Font font3 = new Font("Arial", 10);
            Font font4 = new Font("Courier New", 10);
            var brush = new SolidBrush(Color.Black);
            float fontHeight1 = font1.GetHeight();
            float fontHeight2 = font2.GetHeight();
            float fontHeight3 = font1.GetHeight();


            float startX = 160f;
            float startY = 130f;
            float Offset = 0f;
           
           
            graphics.DrawString("           "+left.orderID, font1, brush, startX, startY + Offset);// sl no
            Offset = Offset + 31f;


            string city = left.companyName +  "[" + left.cityName + "]";// shipping company & city name
            string date =  DateTime.Now.ToShortDateString();
            string cityDateLine = city.PadRight(28) + date; 
            graphics.DrawString("        "+cityDateLine, font2, brush, startX, startY + Offset);// ship by & date


            Offset = Offset + 27f;
            graphics.DrawString("      " + left.customerName.PadRight(30) + left.phoneNumber, font2, brush, startX, startY + Offset);// name & phone

            left.address = left.address.Replace("\n", String.Empty).Replace("\t", String.Empty).Replace("\r", String.Empty);

            Line = FormatMe(left.address, 63);

            string address_bar1 = Line[0];
            
            Offset = Offset + 27f;
            graphics.DrawString("                 "+ address_bar1 , font3, brush, startX, startY + Offset); //address bar 1
            Offset = Offset + 27f;
            if (Line.Count > 1)
            {
                string address_bar2 = Line[1];
                graphics.DrawString("  " + address_bar2, font3, brush, startX, startY + Offset); //address bar 2
            }
          


            Offset = Offset + 50f;
            graphics.DrawString(devideDiscription, font4, brush, startX, startY + Offset); //order item discription;

            devideDiscription = "";

            Offset = Offset + 420f;
            if(flag ==1)
            
            graphics.DrawString(left.bill.ToString().PadLeft(80), font1, brush, startX, startY + Offset); //totalAmount

            flag = 0;

      
            e.HasMorePages = false;

        }




        public List<String> FormatMe(String Message, int MAX_WIDTH)
        {
           
            List<String> Line = new List<String>();
            String[] Words;

            Message = Message.Trim();
            Words = Message.Split(" ".ToCharArray());

            StringBuilder s = new StringBuilder();
            foreach (String Word in Words)
            {
              
                if (s.Length > MAX_WIDTH)
                {
                    if (Word.Length != 0)
                    {

                        s.Replace(Word, "", 0, s.Length - Word.Length);
                        Line.Add(s.ToString().Trim());
                        s = new StringBuilder(Word + " ");
                    }
                }
                else
                    s.Append(Word + " ");
            }

            if (s.Length > 0)
                Line.Add(s.ToString().Trim());


          
          
          return Line;
        }
            public void   GetCustomerInfo(PendingDelivery orderInfo)
            {
                customerNameLabel.Text = orderInfo.customerName;
                shipDateTimePicker.Text = orderInfo.shipDate.ToString();
                cityLabel.Text = orderInfo.cityName;
                shipLabel.Text = orderInfo.companyName;
                phoneLabel.Text = orderInfo.phoneNumber;
                dicountTextBox.Text = orderInfo.discount.ToString();
                addressLabel.Text = orderInfo.address;
                shippingCostLabel.Text = orderInfo.shipCost.ToString();
                toatalAmount.Text = orderInfo.bill.ToString();

                left = orderInfo;
                AddList(left.orderID);
            }

            public void AddList(int orderID)
            {


                List<PendingDelivery> orderlist = new List<PendingDelivery>();

                listItem = leftDA.GetOrderList(orderID);

                
                foreach (PendingDelivery items in listItem)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = items.ProductName;
                    item.SubItems.Add(items.color);
                    item.SubItems.Add("None");
                    item.SubItems.Add(items.unitPrice.ToString());
                    item.SubItems.Add(items.quantity.ToString());
                    item.SubItems.Add(items.totalAmount.ToString());
                   OrderListView.Items.Add(item);

                }


            }

            private void OrderListView_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            public List<string> SetDiscription()
            {

                List<string> dicription = new List<string>();
                

                for (int i = 0; i < PrintlistItem.Count; i++)
                {
                    
                    string slNo = (i + 1).ToString().PadRight(3);
                    string itemName = (PrintlistItem[i].ProductName + " [" + PrintlistItem[i].color + "]");
                   
                    List<string> Line = new List<string>();
                    Line =FormatMe(itemName,25);
                    for(int j=0;j<Line.Count;j++)
                    {
                        if (j == 0)
                        {
                             itemName = Line[j].PadRight(33, '-');
                            string quantity = PrintlistItem[i].quantity.ToString().PadRight(5);
                            string rate = PrintlistItem[i].unitPrice.ToString().PadRight(7);
                            string taka = PrintlistItem[i].totalAmount.ToString();

                            string aLine = "\n " + slNo+" " + itemName + quantity + rate + taka;

                            dicription.Add(aLine);

                        }
                        else
                            dicription.Add("\n    " + Line[j]);

                    }
               


                }
                if(left.shipCost!=0)
                dicription.Add("\n    Delivery Charge".PadRight(52) + left.shipCost);
                if (left.discount != 0)
                dicription.Add("\n    Discount".PadRight(52)+left.discount);

                return dicription;
            }

            private void receiptPrintButton_Click(object sender, EventArgs e)
            {

                PrintlistItem= listItem;
                 List<string>  fullDiscription =new List<string>();
                fullDiscription= SetDiscription();
                double len= Math.Ceiling(Convert.ToDouble(fullDiscription.Count/25));
               
                int c = 0;
                for (int i = 0; i <= len;i++ )
                {
                    
                    for( int j = 0;c< fullDiscription.Count && j<25;j++)
                    {

                        devideDiscription += fullDiscription[c++];
                    }
                    if (i == len)
                        flag = 1;
                    PrintRecipt();

                }




                    
            }

            private void envelopePrintButton_Click(object sender, EventArgs e)
            {
                
                PrintEnvelope();
            }

            private void confirmButton_Click(object sender, EventArgs e)
            {
                left.userId =userInfo.userId;
                double discount=0;
                
                
                  if(confirmationComboBox.Text.Length==0)
                {
                    

                    MessageBox.Show("Please select order status \n");
                 }
                   else
                   {

                       left.order_status = confirmationComboBox.Text;
                       left.order_status_id = orderStatusID[left.order_status];
                       int flag = 0, flag2=0;

                       if (left.order_status == "Paid")
                       {
                           flag = 1;
                         
                           left.shipCost = 0;

                           if (DiscountTextBox.Text.Length != 0)

                               discount = Convert.ToDouble(DiscountTextBox.Text);
                           else
                               discount = left.bill + 100;

                           if (left.bill < discount)
                           {
                               flag = 0;
                               flag2 = 0;
                               MessageBox.Show("Invalid  Discount or empty discount box\n");
                           }
                           else
                           {

                               left.bill -= discount;
                               left.discount += discount;
                               left.shipCost = Convert.ToDouble(shippingCostLabel.Text);
                           }

                       }
                       else if (left.order_status == "Return") 
                       {
                           if(shipCostTextBox.Text.Length==0)
                           {
                               flag = 0;
                               flag2 = 0;
                               MessageBox.Show("Please insert shipping cost\n");                           

                           }
                           else
                           {
                               flag2 = 1;
                               flag = 1;
                               left.shipCost = Convert.ToDouble(shipCostTextBox.Text.Trim());
                               left.bill = left.shipCost;
                               left.discount = 0;

                           }
                           
                       }
                      else if(left.order_status=="Cancel")
                       {
                           flag = 1;
                           flag2 = 1;

                       
                       }
                      if(flag==1 && flag2==1)
                      {
                          leftDA.UpdateQuantity(listItem);
                          
                      }
                      if(flag==1)
                      {
                          
                        left.date=  DateTime.Now.ToString();
                          leftDA.confirmation(left);
                          confirmationComboBox.Text = "";
                          DiscountTextBox.Text = "";
                          shipCostTextBox.Text = "";
                          MessageBox.Show("Thank you\n");

                      }
                      
                   }
            }

            private void toatalAmount_Click(object sender, EventArgs e)
            {

            }

            private void DiscountTextBox_TextChanged(object sender, EventArgs e)
            {
                DiscountTextBox.MaxLength = 8;
            }

            private void DiscountTextBox_KeyPress(object sender, KeyPressEventArgs e)
            {

                if (!char.IsNumber(e.KeyChar))
                {

                    e.Handled = e.KeyChar != (char)Keys.Back && e.KeyChar != (char)'-';

                }
            }

            private void shipCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
            {

                if (!char.IsNumber(e.KeyChar))
                {

                    e.Handled = e.KeyChar != (char)Keys.Back && e.KeyChar != (char)'-';

            
                }
               
            }

            private void shipCostTextBox_TextChanged(object sender, EventArgs e)
            {
                shipCostTextBox.MaxLength = 8;
            }

            private void button1_Click(object sender, EventArgs e)
            {
             left.shipDate =   shipDateTimePicker.Value.ToString();

             left.bill -= Convert.ToInt32(dicountTextBox.Text);
             left.discount += Convert.ToInt32(dicountTextBox.Text);
             leftDA.UpdateDateDiscont(left);

             MessageBox.Show("Update successful");

            }
    }
}
