using System;
namespace SwissTransport
{
    /// <summary>
    /// Type of transportation to filter.
    /// </summary>
    public enum Transportation 
    { 
        /// Transportatino type: IceTgvRj
        IceTgvRj, 
        /// Transportatino type: EcIc
        Ir,
        /// Transportatino type: EcIc
        EcIc, 
        /// Transportatino type: ReD
        ReD,
        /// Transportatino type: Ship 
        Ship, 
        /// Transportatino type: SSNR
        SSNR, 
        /// Transportatino type: Bus
        Bus,
        /// Transportatino type: Cableway
        Cableway,
        /// Transportatino type: ArzExt
        ArzExt,
        /// Transportatino type: TramwayUnderground
        TramwayUnderground
    };

    static class TransportationMethods
    {
        public static String GetString(this Transportation transportation)
        {
            switch (transportation)
            {
                case Transportation.IceTgvRj:
                    return "ice_tgv_rj";
                case Transportation.EcIc:
                    return "ec_ic";
                case Transportation.Ir:
                    return "ir";
                case Transportation.ReD:
                    return "re_d";
                case Transportation.Ship:
                    return "ship";
                case Transportation.SSNR:
                    return "s_sn_r";
                case Transportation.Bus:
                    return "bus";
                case Transportation.Cableway:
                    return "cableway";
                case Transportation.ArzExt:
                    return "arz_ext";
                case Transportation.TramwayUnderground:
                    return "tramway_underground";
                default:
                    throw new Exception();
            }
        }
    }
}
