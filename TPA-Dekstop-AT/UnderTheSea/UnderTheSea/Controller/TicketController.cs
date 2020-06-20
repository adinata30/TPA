using Genesis.QRCodeLib;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace UnderTheSea.Controller
{
    class TicketController
    {
        private static TicketController tc;
        private UnderTheSeaEntities en;
        private TicketController()
        {
            en = UnderTheSeaEntities.getInstance();
        }
        public static TicketController getInstance()
        {
            if(tc==null)
            {
                tc = new TicketController();
                
            }
            return tc;
        }
        public void generateTicket(int kidCount, int adultCount, int elderCount, DateTime date)
        {
            List<Ticket> tickets = new List<Ticket>();
            for (int i = 0; i < kidCount; i++)
            {
                Ticket t = en.Tickets.Create();
                t.TicketDate = date;
                t.TicketPrice = 15000;
                t.TicketType = "Kid";
                t.TicketStatus = "Valid";
                tickets.Add(t);
            }
            for (int i = 0; i < adultCount; i++)
            {
                Ticket t = en.Tickets.Create();
                t.TicketDate = date;
                t.TicketPrice = 40000;
                t.TicketType = "Adult";
                t.TicketStatus = "Valid";
                tickets.Add(t);
            }
            for (int i = 0; i < elderCount; i++)
            {
                Ticket t = en.Tickets.Create();
                t.TicketDate = date;
                t.TicketPrice = 30000;
                t.TicketType = "Elder";
                t.TicketStatus = "Valid";
                tickets.Add(t);
            }
            en.Tickets.AddRange(tickets);
            en.SaveChanges();
        }
        public List<Ticket> getAllTicket()
        {
            return en.Tickets.AsEnumerable().ToList();
        }
        public void updateTicket(Ticket oldTicket, Ticket newTicket)
        {
            int id = oldTicket.TicketID;
            Ticket t = en.Tickets.Where(x => x.TicketID == id).First();
            t.TicketDate = newTicket.TicketDate;
            t.TicketPrice = newTicket.TicketPrice;
            t.TicketStatus = newTicket.TicketStatus;
            t.TicketType = newTicket.TicketType;
            en.SaveChanges();
        }
        public void deleteTicket(Ticket ticket)
        {
            ticket.TicketStatus = "Deleted";
            en.SaveChanges();
        }
        public WriteableBitmap generateQRCode(Ticket t)
        {
            QrEncoder encoder = new QrEncoder(ErrorCorrectionLevel.H);
            var res = encoder.Encode(t.TicketID + "");

            WriteableBitmapRenderer wRenderer = new WriteableBitmapRenderer(new FixedModuleSize(2, QuietZoneModules.Two), Colors.Black, Colors.White);
            WriteableBitmap wBitmap = new WriteableBitmap(51, 51, 5, 5, PixelFormats.Gray8, null);

            wRenderer.Draw(wBitmap, res.Matrix);
            return wBitmap;
        }
        public bool validateTicket(BitmapImage img)
        {
            QRDecoder decoder = new QRDecoder();
            BitmapEncoder encoder = new BmpBitmapEncoder();
            Byte[][] res;
            string result="";
            try
            {
                
                encoder.Frames.Add(BitmapFrame.Create(img));
                System.IO.MemoryStream outStream = new System.IO.MemoryStream();
                encoder.Save(outStream);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(outStream);

                res = decoder.ImageDecoder(bitmap);
                foreach (byte[] temp in res)
                {
                    result = QRCode.ByteArrayToStr(temp);
                }
                

            }
            catch
            {
                return false;
            }
            int id = Int32.Parse(result);
            Ticket t = en.Tickets.Where(x => x.TicketID == id).FirstOrDefault();
            if (t == null) return false;
            DateTime ticketDate =(DateTime) t.TicketDate;
            if (DateTime.Now.DayOfYear - ticketDate.DayOfYear !=0 || t.TicketStatus=="Deleted")
            {
                return false;
            }
            return true;
        }
    }
}
