// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.QuantityResource;
using Xbim.Ifc4.CostResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ConstructionMgmtDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConstructionResource
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConstructionResource : IIfcResource
	{
		IIfcResourceTime @Usage { get;  set; }
		IItemSet<IIfcAppliedValue> @BaseCosts { get; }
		IIfcPhysicalQuantity @BaseQuantity { get;  set; }
	
	}
}

namespace Xbim.Ifc4.ConstructionMgmtDomain
{
	[ExpressType("IfcConstructionResource", 157)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcConstructionResource : IfcResource, IIfcConstructionResource, IEquatable<@IfcConstructionResource>
	{
		#region IIfcConstructionResource explicit implementation
		IIfcResourceTime IIfcConstructionResource.Usage { 
 
 
			get { return @Usage; } 
			set { Usage = value as IfcResourceTime;}
		}	
		IItemSet<IIfcAppliedValue> IIfcConstructionResource.BaseCosts { 
			get { return new Common.Collections.ProxyItemSet<IfcAppliedValue, IIfcAppliedValue>( @BaseCosts); } 
		}	
		IIfcPhysicalQuantity IIfcConstructionResource.BaseQuantity { 
 
 
			get { return @BaseQuantity; } 
			set { BaseQuantity = value as IfcPhysicalQuantity;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConstructionResource(IModel model) : base(model) 		{ 
			_baseCosts = new OptionalItemSet<IfcAppliedValue>( this, 0,  9);
		}

		#region Explicit attribute fields
		private IfcResourceTime _usage;
		private readonly OptionalItemSet<IfcAppliedValue> _baseCosts;
		private IfcPhysicalQuantity _baseQuantity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 20)]
		public IfcResourceTime @Usage 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _usage;
				((IPersistEntity)this).Activate(false);
				return _usage;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _usage = v, _usage, value,  "Usage", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 21)]
		public IOptionalItemSet<IfcAppliedValue> @BaseCosts 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseCosts;
				((IPersistEntity)this).Activate(false);
				return _baseCosts;
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 22)]
		public IfcPhysicalQuantity @BaseQuantity 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseQuantity;
				((IPersistEntity)this).Activate(false);
				return _baseQuantity;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _baseQuantity = v, _baseQuantity, value,  "BaseQuantity", 10);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_usage = (IfcResourceTime)(value.EntityVal);
					return;
				case 8: 
					_baseCosts.InternalAdd((IfcAppliedValue)value.EntityVal);
					return;
				case 9: 
					_baseQuantity = (IfcPhysicalQuantity)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcConstructionResource other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConstructionResource
            var root = (@IfcConstructionResource)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConstructionResource left, @IfcConstructionResource right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcConstructionResource left, @IfcConstructionResource right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}