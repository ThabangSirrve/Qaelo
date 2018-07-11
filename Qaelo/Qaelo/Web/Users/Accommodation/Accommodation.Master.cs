using Qaelo.Data.AccommodationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Qaelo.Web.Users.Accommodation
{
    public partial class Accommodation : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //List<Qaelo.Models.AccommodationModel.RoomAd> rooms = 

            lblNoOfAds.Text = new AccommodationConnection().getAllRoomAds().Count.ToString();
            lblNoOfReservations.Text = new AccommodationConnection().getAllReservations().Count.ToString();
        }
    }
}