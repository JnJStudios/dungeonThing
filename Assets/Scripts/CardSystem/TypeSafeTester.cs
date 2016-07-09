/* --------------------------
 *
 * TypeSafeTester.cs
 *
 * Description: 
 *
 * Author: Jeremy Smellie
 *
 * Editors:
 *
 * 7/8/2016 - DefaultCompany
 *
 * All rights reserved.
 *
 * -------------------------- */

#region Includes
#region Unity Includes
using UnityEngine;
#endregion

#region System Includes
using System.Collections;
#endregion

#region Other Includes

#endregion
#endregion

 namespace Starvoxel.MainProject
{
	public class TypeSafeTester : CustomMono
	{
		#region Fields & Properties
		//const
	
		//public
	
		//protected
	
		//private
	
		//properties
		#endregion
	
		#region Unity Methods
        private void Awake()
        {
            TypeSafeEnum testEnum = TypeSafeEnum.TestEnum1;
        }
		#endregion
	
		#region Public Methods
		#endregion
	
		#region Protected Methods
		#endregion
	
		#region Private Methods
		#endregion
	}
	
}