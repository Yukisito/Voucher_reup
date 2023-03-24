using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace quatitea
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        class Voucher
        {
            public int id { get; set; }
            public string name { get; set; }
            public string imagePath { get; set; }
        }

        public class Point
        {
            private int pointCoin;
            public void setPointCoin(int pointCoin)
            { this.pointCoin = pointCoin; }
            public int getPointCoin()
            { return this.pointCoin; }
        }

        Point p = new Point();
        List<Voucher> list = new List<Voucher>();

        public MainWindow()
        {
            InitializeComponent();
            
            //set diem tich luy
            
            p.setPointCoin(1200);
            lbPoint.Text = p.getPointCoin().ToString();

           
            //set list voucher cua toi
            
            list.Add (new Voucher()
            {
                id = 1,
                name = "Chào mừng khách hàng mới. Khi mới đăng ký \n" +
                "tài khoản, hãy để QualiTea khao ngay 50% giá trị\n" +
                "đơn hàng",
                imagePath = "asset/images/Birthday Voucher-01.png"
            });
            list.Add(new Voucher()
            {
                id = 2,
                name = "Khi quý khách thanh toán 5 sản phẩm tại\n" +
                "QualiTea sẽ được tặng ngay voucher giảm 10%",
                imagePath = "asset/images/Birthday Voucher-10.png"
            });
            list.Add(new Voucher()
            {
                id = 3,
                name = "Tặng ngay voucher giảm 25% khi lần đầu tiên\n" +
                "đặt hàng qua ứng dụng",
                imagePath = "asset/images/Birthday Voucher-25.png"
            });
            list.Add(new Voucher()
            {
                id = 4,
                name = "Voucher giảm 75% sẽ được mở ra vào các khung\n" +
                "giờ vàng, hãy cùng nhau săn nhé",
                imagePath = "asset/images/Birthday Voucher-75.png"
            });
            list.Add(new Voucher()
            {
                id = 4,
                name = "Chà bạn là 1 khách hàng lâu năm của QualiTea\n" +
                "đó, hãy để mình khao bạn 1 sản phẩm nhé",
                imagePath = "asset/images/Birthday Voucher-100.png"
            });

            listbox1.ItemsSource = list;

        }


        
        Border selectedTab;
        private void menuitem_click(object sender, MouseButtonEventArgs e)
        {
            Border bd = (Border)sender;
            selectedTab.Style = this.FindResource("unselectedBtn") as Style;
            bd.Style = this.FindResource("selectedBtn") as Style;
            selectedTab = bd;
        }

        private void menuitem_mouseEnter(object sender, MouseEventArgs e)
        {
            Border bd = (Border)sender;
            bd.Style = this.FindResource("hoverBtn") as Style;
        }

        private void menuitem_mouseLeave(object sender, MouseEventArgs e)
        {
            Border bd = (Border)sender;
            bd.Style = this.FindResource("unselectedBtn") as Style;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }


        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        

        //ktra xem co du diem tich luy hay khong
        private void btnNhan1_Click(object sender, RoutedEventArgs e)
        {
            int i = listbox1.Items.Count;
            if(p.getPointCoin() < 125)
                bdXacNhan.Visibility = Visibility.Visible;
            else
            {
                list.Add(new Voucher()
                {
                    id = i++,
                    name = "Voucher mới nè",
                    imagePath = "asset/images/Birthday Voucher-10.png"
                });
                listbox1.ItemsSource = list;
                p.setPointCoin(p.getPointCoin() - 125);
               

                bdThanhCong.Visibility = Visibility.Visible;
            }
        }

        private void btnKD_Click(object sender, RoutedEventArgs e)
        {
            bdXacNhan.Visibility= Visibility.Collapsed;
            bdThanhCong.Visibility= Visibility.Collapsed;
        }

        private void btnNhan2_Click(object sender, RoutedEventArgs e)
        {
            if (p.getPointCoin() < 900)
                bdXacNhan.Visibility = Visibility.Visible;
            else
            {
                bdThanhCong.Visibility = Visibility.Visible;
            }
        }

        private void btnNhan3_Click(object sender, RoutedEventArgs e)
        {
            if (p.getPointCoin() < 680)
                bdXacNhan.Visibility = Visibility.Visible;
            else
            {
                bdThanhCong.Visibility = Visibility.Visible;
            }
        }
    }
}
