using CompraBoletosAereos_Dquan.Listas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraBoletosAereos_Dquan
{
    public partial class Form1 : Form
    {
        // Airlines
        public Lista BritishAirline = new Lista();
        public Lista AmericanAirline = new Lista();
        public Lista ColombianAirline = new Lista();
        public Lista MexicoAirline = new Lista();
        public Lista GuatemalaAirline = new Lista();
        public Lista SpainAirline = new Lista();
        // Countries
        public Lista DepartureCountry = new Lista();
        public Lista ArrivalCountry = new Lista();
        // Departure Airports
        public Lista BritishAirport = new Lista(); 
        public Lista AmericanAirport = new Lista();
        public Lista ColombianAirport = new Lista();
        public Lista MexicoAirport = new Lista();
        public Lista GuatemalaAirport = new Lista();
        public Lista SpainAirport = new Lista(); 
        // Arrival Airports
        public Lista ArrivalBritishAirport = new Lista();
        public Lista ArrivalAmericanAirport = new Lista();
        public Lista ArrivalColombianAirport = new Lista();
        public Lista ArrivalMexicoAirport = new Lista();
        public Lista ArrivalGuatemalaAirport = new Lista();
        public Lista ArrivalSpainAirport = new Lista();
        // Schedule
        // UK
        public Lista UK_MXSchedule = new Lista();
        public Lista UK_GTSchedule = new Lista();
        public Lista UK_SPSchedule = new Lista();
        // American
        public Lista USA_MXSchedule = new Lista();
        public Lista USA_GTSchedule = new Lista();
        public Lista USA_SPSchedule = new Lista();
        // Colombian
        public Lista COL_MXSchedule = new Lista();
        public Lista COL_GTSchedule = new Lista();
        public Lista COL_SPSchedule = new Lista();
        // Tickets
        // Ticket Type
        public Lista TicketType = new Lista();
        // Bought Tickets
        public Ticket Ticket = new Ticket();
        // Nationality
        public Lista Nationality = new Lista();
        // Payment Method
        public Lista PaymentMethod = new Lista();
        // Ticket counter
        int counter = 0;
        // Random
        int min = 1;
        int max = 10;
        int TicketMin = 1000;
        int TicketMax = 10000;
        Random rnd = new Random();
        //Ticket Cost
        int TicketCost = 0;
        // UK 
        int UK_GT = 300;
        int UK_MX = 310;
        int UK_SP = 35;
        // USA
        int USA_GT = 45;
        int USA_MX = 57;
        int USA_SP = 146;
        // COL
        int COL_GT = 155;
        int COL_MX = 160;
        int COL_SP = 344;
        // Client Info
        public Client Client = new Client();

        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            uploadData();
            // Countries
            UploadCountry();
            UploadArrivalCountry();
            //Airlines
            UploadBritisAirline();
            UploadAmericanAirline();
            UploadColombianAirline();
        }

        // Data

        public void uploadData ()
        {
            // Airlines
            BritishAirline.addList("------- Select an Airline -------");
            BritishAirline.addList("British Airways");
            BritishAirline.addList("easyJet");
            BritishAirline.addList("Wizz Air UK");

            AmericanAirline.addList("------- Select an Airline -------");
            AmericanAirline.addList("Alaska Airlines");
            AmericanAirline.addList("American Airlines");
            AmericanAirline.addList("Allegiant Air");

            ColombianAirline.addList("------- Select an Airline -------");
            ColombianAirline.addList("Avianca");
            ColombianAirline.addList("EasyFly");
            ColombianAirline.addList("Wingo");

            // Countries
            DepartureCountry.addList("------- Select a Country -------");
            DepartureCountry.addList("United Kingdom");
            DepartureCountry.addList("United States of America");
            DepartureCountry.addList("Colombia");

            ArrivalCountry.addList("------- Select a Country -------");
            ArrivalCountry.addList("Mexico");
            ArrivalCountry.addList("Guatemala");
            ArrivalCountry.addList("Spain");

            // Airports
            // Departure Airports
            // British Airport
            BritishAirport.addList("------- Select an Airport -------");
            BritishAirport.addList("Londres Heathrow | United Kingdom");
            BritishAirport.addList("Londres Gatwick | United Kingdom");
            BritishAirport.addList("Birmingham | United Kingdom");

            // American Airport
            AmericanAirport.addList("------- Select an Airport -------");
            AmericanAirport.addList("Houston | United States of America");
            AmericanAirport.addList("New York | United States of America");
            AmericanAirport.addList("Los Angeles | United States of America");

            // Colombian Airport
            ColombianAirport.addList("------- Select an Airport -------");
            ColombianAirport.addList("Bogota | Colombia");
            ColombianAirport.addList("Cartagena | Colombia");
            ColombianAirport.addList("Medellin | Colombia");

            // Mexican Airport
            MexicoAirport.addList("------- Select an Airport -------");
            MexicoAirport.addList("CDMX | Mexico");
            MexicoAirport.addList("Cancun | Mexico");
            MexicoAirport.addList("Acapulco | Mexico");

            // Guatemalan Airport
            GuatemalaAirport.addList("------- Select an Airport -------");
            GuatemalaAirport.addList("Ciudad de Guatemala | Guatemala");
            GuatemalaAirport.addList("Peten | Guatemala");
            GuatemalaAirport.addList("Xela | Guatemala");

            // Spanish Airport
            SpainAirport.addList("------- Select an Airport -------");
            SpainAirport.addList("Barcelona | Spain");
            SpainAirport.addList("Madrid | Spain");
            SpainAirport.addList("Canarias | Spain");

            // Arrival Airports
            // British Airport
            ArrivalBritishAirport.addList("------- Select an Airport -------");
            ArrivalBritishAirport.addList("Londres Heathrow | United Kingdom");
            ArrivalBritishAirport.addList("Londres Gatwick | United Kingdom");
            ArrivalBritishAirport.addList("Birmingham | United Kingdom");

            // American Airport
            ArrivalAmericanAirport.addList("------- Select an Airport -------");
            ArrivalAmericanAirport.addList("Houston | United States of America");
            ArrivalAmericanAirport.addList("New York | United States of America");
            ArrivalAmericanAirport.addList("Los Angeles | United States of America");

            // Colombian Airport
            ArrivalColombianAirport.addList("------- Select an Airport -------");
            ArrivalColombianAirport.addList("Bogota | Colombia");
            ArrivalColombianAirport.addList("Cartagena | Colombia");
            ArrivalColombianAirport.addList("Medellin | Colombia");

            // Mexican Airport
            ArrivalMexicoAirport.addList("------- Select an Airport -------");
            ArrivalMexicoAirport.addList("CDMX | Mexico");
            ArrivalMexicoAirport.addList("Cancun | Mexico");
            ArrivalMexicoAirport.addList("Acapulco | Mexico");

            // Guatemalan Airport
            ArrivalGuatemalaAirport.addList("------- Select an Airport -------");
            ArrivalGuatemalaAirport.addList("Ciudad de Guatemala | Guatemala");
            ArrivalGuatemalaAirport.addList("Peten | Guatemala");
            ArrivalGuatemalaAirport.addList("Xela | Guatemala");

            // Spanish Airport
            ArrivalSpainAirport.addList("------- Select an Airport -------");
            ArrivalSpainAirport.addList("Barcelona | Spain");
            ArrivalSpainAirport.addList("Madrid | Spain");
            ArrivalSpainAirport.addList("Canarias | Spain");

            //Schedules
            // UK - MX
            UK_MXSchedule.addList("------- Select Schedule -------");
            UK_MXSchedule.addList("10:00 -> 19:00");
            UK_MXSchedule.addList("11:00 -> 20:00");
            // UK - GT
            UK_GTSchedule.addList("------- Select Schedule -------");
            UK_GTSchedule.addList("10:00 -> 20:00");
            UK_GTSchedule.addList("11:00 -> 21:00");
            // UK - SP 
            UK_SPSchedule.addList("------- Select Schedule -------");
            UK_SPSchedule.addList("11:00 -> 13:00");
            UK_SPSchedule.addList("12:00 -> 14:00");
            // USA - MX
            USA_MXSchedule.addList("------- Select Schedule -------");
            USA_MXSchedule.addList("13:00 -> 14:00");
            USA_MXSchedule.addList("14:00 -> 15:00");
            // USA - GT
            USA_GTSchedule.addList("------- Select Schedule -------");
            USA_GTSchedule.addList("12:00 -> 17:00");
            USA_GTSchedule.addList("13:00 -> 18:00");
            // USA - SP 
            USA_SPSchedule.addList("------- Select Schedule -------");
            USA_SPSchedule.addList("10:00 -> 19:00");
            USA_SPSchedule.addList("11:00 -> 20:00");
            // COL - MX
            COL_MXSchedule.addList("------- Select Schedule -------");
            COL_MXSchedule.addList("9:00 -> 13:00");
            COL_MXSchedule.addList("10:00 -> 14:00");
            // COL - GT
            COL_GTSchedule.addList("------- Select Schedule -------");
            COL_GTSchedule.addList("9:00 -> 12:00");
            COL_GTSchedule.addList("10:00 -> 13:00");
            // COL - SP 
            COL_SPSchedule.addList("------- Select Schedule -------");
            COL_SPSchedule.addList("10:00 -> 21:00");
            COL_SPSchedule.addList("11:00 -> 22:00");

            // Ticket Type
            TicketType.addList("------- Select Ticket Type -------");
            TicketType.addList("Turist | Window");
            TicketType.addList("Turist | Hallway");
            TicketType.addList("Bussines | Window");
            TicketType.addList("Bussines | Hallway");

            // Nationality 
            Nationality.addList("------- Select a nationality -------");
            Nationality.addList("British");
            Nationality.addList("American");
            Nationality.addList("Colombian");

            // Payment Method 
            PaymentMethod.addList("------- Select a payment method -------");
            PaymentMethod.addList("Cash");
            PaymentMethod.addList("Credit/debit Card");
        }

        // Data Upload
        // Airlines
        public void UploadBritisAirline()
        {
            comboBox1.DataSource = BritishAirline.addList();
        }

        public void UploadAmericanAirline()
        {
            comboBox1.DataSource = AmericanAirline.addList();
        }
        public void UploadColombianAirline()
        {
            comboBox1.DataSource = ColombianAirline.addList();
        }
        public void UploadMexicanAirline()
        {
            comboBox1.DataSource = MexicoAirline.addList();
        }
        public void UploadGuatemalaAirline()
        {
            comboBox1.DataSource = GuatemalaAirline.addList();
        }
        public void UploadSpainAirline()
        {
            comboBox1.DataSource = SpainAirline.addList();
        }

        // Countries
        public void UploadCountry()
        {
            comboBox2.DataSource = DepartureCountry.addList();
        }

        public void UploadArrivalCountry ()
        {
            comboBox4.DataSource = ArrivalCountry.addList();
        }

        // Departure Airports - Upload Data
        public void UploadAirportUK()
        {
            comboBox3.DataSource = BritishAirport.addList();
        }

        public void UploadAirportUSA()
        {
            comboBox3.DataSource = AmericanAirport.addList();
        }

        public void UploadAirportColombia()
        {
            comboBox3.DataSource = ColombianAirport.addList();
        }

        public void UploadAirportMexico()
        {
            comboBox3.DataSource = MexicoAirport.addList();
        }

        public void UploadAirportGuatemala()
        {
            comboBox3.DataSource = GuatemalaAirport.addList();
        }

        public void UploadAirportSpain()
        {
            comboBox3.DataSource = SpainAirport.addList();
        }

        // Arrival Airports - Upload Data
        public void UploadArrivalAirportUK ()
        {
            comboBox5.DataSource = ArrivalBritishAirport.addList();
        }
        public void UploadArrivalAirportUSA()
        {
            comboBox5.DataSource = ArrivalAmericanAirport.addList();
        }

        public void UploadArrivalAirportColombia ()
        {
            comboBox5.DataSource = ArrivalColombianAirport.addList();
        }

        public void UploadArrivalAirportMexico ()
        {
            comboBox5.DataSource = ArrivalMexicoAirport.addList();
        }

        public void UploadArrivalAirportGuatemala ()
        {
            comboBox5.DataSource = ArrivalGuatemalaAirport.addList();
        }

        public void UploadArrivalAirportSpain ()
        {
            comboBox5.DataSource = ArrivalSpainAirport.addList();
        }

        // Schedules
        // UK
        public void UploadUK_MXSchedule ()
        {
            comboBox6.DataSource = UK_MXSchedule.addList();
        }

        public void UploadUK_GTSchedule()
        {
            comboBox6.DataSource = UK_GTSchedule.addList();
        }

        public void UploadUK_SPSchedule()
        {
            comboBox6.DataSource = UK_SPSchedule.addList();
        }

        // USA
        public void UploadUSA_MXSchedule()
        {
            comboBox6.DataSource = USA_MXSchedule.addList();
        }

        public void UploadUSA_GTSchedule()
        {
            comboBox6.DataSource = USA_GTSchedule.addList();
        }

        public void UploadUSA_SPSchedule()
        {
            comboBox6.DataSource = USA_SPSchedule.addList();
        }

        // COL
        public void UploadCOL_MXSchedule()
        {
            comboBox6.DataSource = COL_MXSchedule.addList();
        }

        public void UploadCOL_GTSchedule()
        {
            comboBox6.DataSource = COL_GTSchedule.addList();
        }

        public void UploadCOL_SPSchedule()
        {
            comboBox6.DataSource = COL_SPSchedule.addList();
        }

        // Ticket Type
        public void UploadTicketType()
        {
            comboBox7.DataSource = TicketType.addList();
        }

        // Nationality 
        public void UploadNationality()
        {
            comboBox9.DataSource = Nationality.addList();
        }

        // Payment Method
        public void UploadPaymentMethod()
        {
            comboBox10.DataSource = PaymentMethod.addList();
        }

        // Button Clicks
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0 || comboBox4.SelectedIndex == 0 || comboBox1.SelectedIndex == 0 || comboBox3.SelectedIndex == 0 || comboBox5.SelectedIndex == 0)
            {
                label15.Text = "Please provide all the info needed.";
            } else { 
                groupBox1.Visible = false;
                groupBox3.Visible = true;

                Ticket.departureCountry = comboBox2.SelectedItem.ToString();
                Ticket.airline = comboBox1.SelectedItem.ToString();
                Ticket.departureAirport = comboBox3.SelectedItem.ToString();
                Ticket.arrivalCountry = comboBox4.SelectedItem.ToString();
                Ticket.arrivalAirport = comboBox5.SelectedItem.ToString();

                // Ticket Type
                UploadTicketType();
                // Schedules
                if (comboBox2.Text == "United Kingdom" && comboBox4.Text == "Guatemala") // UK
                {
                    UploadUK_GTSchedule();
                }
                else if (comboBox2.Text == "United Kingdom" && comboBox4.Text == "Mexico")
                {
                    UploadUK_MXSchedule();
                }
                else if (comboBox2.Text == "United Kingdom" && comboBox4.Text == "Spain")
                {
                    UploadUK_SPSchedule();
                }
                else if (comboBox2.Text == "United States of America" && comboBox4.Text == "Guatemala") // USA
                {
                    UploadUSA_GTSchedule();
                }
                else if (comboBox2.Text == "United States of America" && comboBox4.Text == "Mexico")
                {
                    UploadUSA_MXSchedule();
                }
                else if (comboBox2.Text == "United States of America" && comboBox4.Text == "Spain")
                {
                    UploadUSA_SPSchedule();
                }
                else if (comboBox2.Text == "Colombia" && comboBox4.Text == "Guatemala") // COL
                {
                    UploadCOL_MXSchedule();
                }
                else if (comboBox2.Text == "Colombia" && comboBox4.Text == "Mexico")
                {
                    UploadCOL_GTSchedule();
                }
                else if (comboBox2.Text == "Colombia" && comboBox4.Text == "Spain")
                {
                    UploadCOL_SPSchedule();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;

            UploadNationality();
            UploadPaymentMethod();

            int TicketNo = rnd.Next(TicketMin, TicketMax);

            if (comboBox6.SelectedIndex == 0 || comboBox7.SelectedIndex == 0)
            {
                label29.Text = "Please provide all the info needed.";
            }
            else
            {
                groupBox3.Visible = false;
                groupBox2.Visible = true;

                Ticket.ticketNo = TicketNo;
                Ticket.schedule = comboBox6.SelectedItem.ToString();
                Ticket.gate = label16.Text;
                Ticket.ticketCost = label17.Text;
                Ticket.lugagge = label18.Text;
                Ticket.ticketType = comboBox7.SelectedItem.ToString();
                Ticket.totalCost = label20.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox1.Visible = true;

            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexAirline = comboBox2.SelectedIndex;

            switch (indexAirline)
            {
                case 1:
                    UploadBritisAirline();
                break;
                case 2:
                    UploadAmericanAirline(); 
                break;
                case 3:
                    UploadColombianAirline();
                break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexCountry = comboBox2.SelectedIndex;

            switch (indexCountry)
            {
                case 1:
                    UploadAirportUK();
                    break;
                case 2:
                    UploadAirportUSA();
                    break;
                case 3:
                    UploadAirportColombia();
                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexArrivalCountry = comboBox4.SelectedIndex;

            switch (indexArrivalCountry)
            {
                case 1:
                    UploadArrivalAirportMexico();
                    break;
                case 2:
                    UploadArrivalAirportGuatemala();
                    break;
                case 3:
                    UploadArrivalAirportSpain();
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UploadArrivalCountry();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            label14.Text = "Schedule: ";
            label16.Text = "Gate: ";
            label17.Text = "Ticket Cost: ";
            label18.Text = "Lugagge: ";

            int indexSchedule = comboBox6.SelectedIndex;

            if (indexSchedule != 0)
            {
                if (comboBox2.Text == "United Kingdom" && comboBox4.Text == "Guatemala") // UK
                {
                    TicketCost = UK_GT;
                }
                else if (comboBox2.Text == "United Kingdom" && comboBox4.Text == "Mexico")
                {
                    TicketCost = UK_MX;
                }
                else if (comboBox2.Text == "United Kingdom" && comboBox4.Text == "Spain")
                {
                    TicketCost = UK_SP;
                }
                else if (comboBox2.Text == "United States of America" && comboBox4.Text == "Guatemala") // USA
                {
                    TicketCost = USA_GT;
                }
                else if (comboBox2.Text == "United States of America" && comboBox4.Text == "Mexico")
                {
                    TicketCost = USA_MX;
                }
                else if (comboBox2.Text == "United States of America" && comboBox4.Text == "Spain")
                {
                    TicketCost = USA_SP;
                }
                else if (comboBox2.Text == "Colombia" && comboBox4.Text == "Guatemala") // COL
                {
                    TicketCost = COL_GT;
                }
                else if (comboBox2.Text == "Colombia" && comboBox4.Text == "Mexico")
                {
                    TicketCost = COL_MX;
                }
                else if (comboBox2.Text == "Colombia" && comboBox4.Text == "Spain")
                {
                    TicketCost = COL_SP;
                }

                // Gate 
                int gate = rnd.Next(min, max);
                label14.Text = label14.Text + comboBox6.Text;
                label16.Text = label16.Text + Convert.ToString(gate);
                label17.Text = label17.Text + "USD$" + TicketCost;
                label18.Text = label18.Text + "1 handbag";
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexTicketType = comboBox7.SelectedIndex;

            switch (indexTicketType)
            {
                case 1:
                    label20.Text = "Total: USD$" + Convert.ToString(TicketCost + (TicketCost * 0.10));
                    break;
                case 2:
                    label20.Text = "Total: USD$" + Convert.ToString(TicketCost);
                    break;
                case 3:
                    label20.Text = "Total: USD$" + Convert.ToString(TicketCost + (TicketCost * 0.25) + (TicketCost * 0.10));
                    break;
                case 4:
                    label20.Text = "Total: USD$" + Convert.ToString(TicketCost + (TicketCost * 0.25));
                    break;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Client.name = textBox1.Text;
            Client.surname = textBox2.Text;
            Client.passportNo = Convert.ToInt64(textBox3.Text);
            Client.DPINo = Convert.ToInt64(textBox4.Text);
            Client.NIT = Convert.ToInt32(textBox5.Text);
            if (comboBox9.SelectedIndex != 0)
            {
                Client.nationality = comboBox9.Text;
            }
            Client.phoneNo = Convert.ToInt32(textBox6.Text);
            Client.address = textBox7.Text;
            Client.email = textBox8.Text;
            if (comboBox10.SelectedIndex != 0)
            {
                Client.paymentMethod = comboBox10.Text;
            }

            if (comboBox10.SelectedIndex == 2)
            {
                if (textBox9.TextLength == 13)
                {
                    groupBox2.Visible = false;
                    groupBox4.Visible = true;
                } else
                {
                    label31.Text = "Please check the card info";
                }
            } else if (comboBox10.SelectedIndex == 1)
            {
                groupBox2.Visible = false;
                groupBox4.Visible = true;
            } else
            {
                label31.Text = "Please select a payment method.";
            }

            label32.Text = "Ticket Number: " + Ticket.ticketNo;
            label33.Text = "Airline: " + Ticket.airline;
            label34.Text = "Departure Country: " + Ticket.departureCountry;
            label35.Text = "Arrival Country: " + Ticket.arrivalCountry;
            label36.Text = "Departure Airport: " + Ticket.departureAirport;
            label37.Text = "Arrival Country: " + Ticket.arrivalAirport;
            label38.Text = "Schedule: " + Ticket.schedule;
            label39.Text = "Passport Number: " + Client.passportNo;
            label40.Text = "Name: " + Client.name + " " + Client.surname;
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.SelectedIndex == 2) 
            {
                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
                label30.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;

            label14.Text = "Schedule: ";
            label16.Text = "Gate: ";
            label17.Text = "Ticket Cost: ";
            label18.Text = "Lugagge: ";
            label20.Text = "Total: ";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
