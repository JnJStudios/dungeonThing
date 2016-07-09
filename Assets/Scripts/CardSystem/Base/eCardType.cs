/* --------------------------
 *
 * eCardType.cs
 *
 * Description: Typesafe enum for the various card types
 *
 * Author: Jeremy Smellie
 *
 * Editors:
 *
 * 7/5/2016 - J & J
 *
 * All rights reserved.
 *
 * -------------------------- */

#region Includes
#region System Includes
using System.Collections;
#endregion

#region Other Includes
using Starvoxel.Core;
#endregion
#endregion

 namespace JJ.DungeonThing
{
	public class eCardType : TypeSafeEnum
	{
		#region Enum Values
        public static readonly eCardType Damage = new eCardType("Damage");
        public static readonly eCardType Minion = new eCardType("Minion");
        #endregion

        #region Constructor Methods
        protected eCardType(string value) : base(value, null) {	}
		#endregion
	}
	
}