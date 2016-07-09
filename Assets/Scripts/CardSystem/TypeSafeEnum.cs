/* --------------------------
 *
 * TypeSafeEnum.cs
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
#region System Includes
using System.Collections;
using System.Reflection;
#endregion

#region Other Includes

#endregion
#endregion

 namespace Starvoxel.Core
{
	public class TypeSafeEnum
	{
		#region Fields & Properties
		//const
	
		//public
	
		//protected
        protected string m_Value = null;
        protected string m_Description = null;

		//private
	
		//properties
        public string Value
        {
            get { return m_Value; }
        }

        public string Description
        {
            get { return m_Description; }
        }
		#endregion
	
		#region Constructor Methods
		protected TypeSafeEnum(string value, string description = null)
		{
            m_Value = value;
            m_Description = description;
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