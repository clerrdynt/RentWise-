using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentWise_
{
    public partial class EventCard : UserControl
    {
        public EventCard()
        {
            InitializeComponent();
        }

        private void EventCard_Load(object sender, EventArgs e)
        {
            
        }
        public string EventName
        {
            get => lblEventName.Text;
            set => lblEventName.Text = value;
        }
        public string EventWhen
        {
            get => lblEventWhen.Text;
            set => lblEventWhen.Text = value;
        }
        public string EventWhere
        {
            get => lblEventWhere.Text;
            set => lblEventWhere.Text = value;
        }

    }
}
