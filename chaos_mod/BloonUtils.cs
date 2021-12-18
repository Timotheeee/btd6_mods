using Assets.Scripts.Models.Bloons;
using Assets.Scripts.Unity;

using System;
using Assets.Scripts.Simulation.Bloons;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MelonLoader;
using Harmony;
using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;
using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;
using Assets.Scripts.Unity.UI_New.Main;

using Assets.Scripts.Models.Towers;





using Assets.Scripts.Simulation.Towers;

using Assets.Scripts.Utils;



using Assets.Scripts.Models;


using Assets.Scripts.Unity.Menu;
using Assets.Scripts.Models.Towers.Projectiles;
using Assets.Scripts.Models.Towers.Weapons;
using Assets.Scripts.Models.Rounds;
using UnhollowerBaseLib;
using System.Linq;
using Assets.Scripts.Unity.UI_New.Races;
using Assets.Scripts.Models.Store;
using Assets.Scripts.Models.Store.Loot;
using Assets.Scripts.Unity.Gift;
using System.Text.RegularExpressions;


using Assets.Scripts.Unity.Analytics;
using Assets.Scripts.Simulation.Towers.Projectiles;
using UnhollowerRuntimeLib;


using System.Text;
using System.Threading.Tasks;


namespace chaosmod
{
    class BloonUtils
    {

        public enum DefaultBloonIds
        {
            Red,
            RedRegrow,
            RedRegrowCamo,
            RedCamo,
            Blue,
            BlueRegrow,
            BlueRegrowCamo,
            BlueCamo,
            Green,
            GreenRegrow,
            GreenRegrowCamo,
            GreenCamo,
            Yellow,
            YellowRegrow,
            YellowRegrowCamo,
            YellowCamo,
            Pink,
            PinkRegrow,
            PinkRegrowCamo,
            PinkCamo,
            Black,
            BlackRegrow,
            BlackRegrowCamo,
            BlackCamo,
            White,
            WhiteRegrow,
            WhiteRegrowCamo,
            WhiteCamo,
            Purple,
            PurpleRegrow,
            PurpleRegrowCamo,
            PurpleCamo,
            Zebra,
            ZebraRegrow,
            ZebraRegrowCamo,
            ZebraCamo,
            Lead,
            LeadRegrow,
            LeadRegrowFortified,
            LeadRegrowFortifiedCamo,
            LeadRegrowCamo,
            LeadFortified,
            LeadFortifiedCamo,
            LeadCamo,
            Rainbow,
            RainbowRegrow,
            RainbowRegrowCamo,
            RainbowCamo,
            Ceramic,
            CeramicRegrow,
            CeramicRegrowFortified,
            CeramicRegrowFortifiedCamo,
            CeramicRegrowCamo,
            CeramicFortified,
            CeramicFortifiedCamo,
            CeramicCamo,
            Moab,
            MoabFortified,
            Bfb,
            BfbFortified,
            Zomg,
            ZomgFortified,
            Ddt,
            DdtFortified,
            DdtFortifiedCamo,
            DdtCamo,
            Bad,
            BadFortified,
            TestBloon
        }

        /// <summary>
        /// A list of all bloons currently on the map. Updated when a bloon is initialised or destroyed
        /// </summary>
        public static List<Bloon> BloonsOnMap = new List<Bloon>();

        /// <summary>
        /// Get a list of all of the default bloon ids. Doesn't get custom bloons
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllBloonTypes()
        {
            var allBloonTypes = new List<string>();
            //foreach (var item in EnumUtils.GetValues<DefaultBloonIds>())
            //    allBloonTypes.Add(item.ToString());

            return allBloonTypes;
        }


        /// <summary>
        /// Get the number ID of the bloon. Mainly used to get the numeric position of bloon in the list of DefaultBloonIds
        /// </summary>
        /// <param name="bloonId">bloon name of bloon you want Id for</param>
        /// <returns></returns>
        public static int GetBloonIdNum(string bloonId)
        {
            int result = 0;
            var allBloons = GetAllBloonTypes();
            for (int i = 0; i < allBloons.Count; i++)
            {
                if (allBloons[i].ToLower() != bloonId.ToLower())
                    continue;

                result = i;
                break;
            }

            return result;
        }


        public static BloonModel SetBloonStatus(string bloonId, [Optional] bool setCamo, [Optional] bool setFortified, [Optional] bool setRegrow)
        {
            string camoText = "";
            string fortifiedText = "";
            string regrowText = "";
            string bloonBase = bloonId.Replace("Camo", "").Replace("Fortified", "").Replace("Regrow", "");

            if (setCamo || (bloonId.Contains("Camo")))
            {
                if (GetBloon(bloonBase + "Camo", true) != null)
                    camoText = "Camo";
            }
            if (setFortified || (bloonId.Contains("Fortified")))
            {
                if (GetBloon(bloonBase + "Fortified", true) != null)
                    fortifiedText = "Fortified";
            }
            if (setRegrow || (bloonId.Contains("Regrow")))
            {
                if (GetBloon(bloonBase + "Regrow", true) != null)
                    regrowText = "Regrow";
            }

            string newBloonID = bloonBase + regrowText + fortifiedText + camoText;
            var newBloon = GetBloon(newBloonID, true);

            return newBloon;
        }


        /// <summary>
        /// Get the next strongest bloon. Ex: the next strongest bloon after Red is Red Regrow
        /// </summary>
        /// <param name="bloon">The bloon id of the current bloon. Ex: Red</param>
        /// <param name="allowCamo">Is it okay if the next bloon is a camo bloon. Ex: Red => RedCamo</param>
        /// <param name="allowFortified">Is it okay if the next bloon is a Fortified bloon. Ex: Red => RedFortified</param>
        /// <param name="allowRegrow">Is it okay if the next bloon is a Regrow bloon. Ex: Red => RedRegrow</param>
        /// <returns>The next strongest bloon</returns>
        public static BloonModel GetNextStrongestBloon(BloonModel bloon, bool allowCamo = true,
            bool allowFortified = true, bool allowRegrow = true, bool ignoreException = false) => GetNextStrongestBloon(bloon.name,
                allowCamo, allowFortified, allowRegrow, true);

        /// <summary>
        /// Get the next strongest bloon. Ex: the next strongest bloon after Red is Red Regrow
        /// </summary>
        /// <param name="bloonId">The bloon id of the current bloon. Ex: Red</param>
        /// <param name="allowCamo">Is it okay if the next bloon is a camo bloon. Ex: Red => RedCamo</param>
        /// <param name="allowFortified">Is it okay if the next bloon is a Fortified bloon. Ex: Red => RedFortified</param>
        /// <param name="allowRegrow">Is it okay if the next bloon is a Regrow bloon. Ex: Red => RedRegrow</param>
        /// <returns>The next strongest bloon</returns>
        public static BloonModel GetNextStrongestBloon(DefaultBloonIds bloonId, bool allowCamo = true,
            bool allowFortified = true, bool allowRegrow = true, bool ignoreException = false) => GetNextStrongestBloon(bloonId.ToString(),
                allowCamo, allowFortified, allowRegrow, true);


        /// <summary>
        /// Get the next strongest bloon. Ex: the next strongest bloon after Red is Red Regrow
        /// </summary>
        /// <param name="bloonId">The bloon id of the current bloon. Ex: Red</param>
        /// <param name="allowCamo">Is it okay if the next bloon is a camo bloon. Ex: Red => RedCamo</param>
        /// <param name="allowFortified">Is it okay if the next bloon is a Fortified bloon. Ex: Red => RedFortified</param>
        /// <param name="allowRegrow">Is it okay if the next bloon is a Regrow bloon. Ex: Red => RedRegrow</param>
        /// <returns>The next strongest bloon</returns>
        public static BloonModel GetNextStrongestBloon(string bloonId, bool allowCamo = true,
            bool allowFortified = true, bool allowRegrow = true, bool ignoreException = false)
        {
            var allBloonTypes = GetAllBloonTypes();

            string nextBloon = bloonId;
            int max = allBloonTypes.Count - 1; // subtract 1 more here to avoid test bloon
            for (int i = 0; i < max; i++)
            {
                if (bloonId.ToLower() != allBloonTypes[i].ToLower())
                    continue;

                nextBloon = allBloonTypes[i];
            }

            var nextBloonModel = RemoveBloonStatus(nextBloon, !allowCamo, !allowFortified, !allowRegrow, true);
            return nextBloonModel;
        }

        /// <summary>
        /// Get the next weakest bloon. Ex: the next strongest bloon after Red is Red Regrow
        /// </summary>
        /// <param name="bloonId">The bloon id of the current bloon. Ex: Red</param>
        /// <param name="allowCamo">Is it okay if the next bloon is a camo bloon. Ex: Red => RedCamo</param>
        /// <param name="allowFortified">Is it okay if the next bloon is a Fortified bloon. Ex: Red => RedFortified</param>
        /// <param name="allowRegrow">Is it okay if the next bloon is a Regrow bloon. Ex: Red => RedRegrow</param>
        /// <returns>The next strongest bloon</returns>
        public static BloonModel GetNextWeakestBloon(string bloonId, bool allowCamo = true,
            bool allowFortified = true, bool allowRegrow = true)
        {
            var allBloonTypes = GetAllBloonTypes();

            string nextBloon = bloonId;
            int max = allBloonTypes.Count - 1; // subtract 1 more here to avoid test bloon
            for (int i = 0; i < max; i++)
            {
                if (bloonId.ToLower() != allBloonTypes[i].ToLower())
                    continue;

                if (i == 0)
                {
                    nextBloon = allBloonTypes[0];
                    break;
                }
                nextBloon = allBloonTypes[i - 1];
                break;
            }

            var nextWeakestBloon = SetBloonStatus(nextBloon, allowCamo, allowFortified, allowRegrow);
            return nextWeakestBloon;
        }


        /// <summary>
        /// Get the BloonModel of the bloonId you enter
        /// </summary>
        /// <param name="bloonId">The ID of the bloon you want</param>
        /// <returns></returns>
        public static BloonModel GetBloon(DefaultBloonIds bloonId, bool isCamo = false, bool isFortified = false, bool isRegrow = false,
            bool ignoreException = true) => GetBloon(bloonId.ToString(), isCamo, isFortified, isRegrow, true);


        /// <summary>
        /// Get the BloonModel of the bloonId you enter
        /// </summary>
        /// <param name="bloonId">The ID of the bloon you want</param>
        /// <returns></returns>
        public static BloonModel GetBloon(string bloonId, bool isCamo = false, bool isFortified = false, bool isRegrow = false,
            bool ignoreException = true)
        {
            BloonModel result = null;

            if (Game.instance == null)
            {

                return result;
            }
            else if (Game.instance.model == null)
            {

                return result;
            }

            try
            {
                result = Game.instance.model.GetBloon(bloonId);
            }
            catch (Exception e)
            {
                if (ignoreException)
                    return result;


            }

            return result;
        }


        public static BloonModel RemoveBloonStatus(string bloonId, bool removeCamo, bool removeFortified, bool removeRegrow, bool ignoreException = false)
        {
            if (bloonId.Contains("Camo") && removeCamo)
                bloonId = bloonId.Replace("Camo", "");
            if (bloonId.Contains("Fortified") && removeFortified)
                bloonId = bloonId.Replace("Fortified", "");
            if (bloonId.Contains("Regrow") && removeRegrow)
                bloonId = bloonId.Replace("Regrow", "");

            var bloon = GetBloon(bloonId, true);
            if (bloon == null)
            {

                return null;
            }

            return bloon;
        }
    }
}
