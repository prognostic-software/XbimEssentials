// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelDecomposes
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelDecomposes : IIfcRelationship
	{
		IIfcObjectDefinition @RelatingObject { get;  set; }
		IItemSet<IIfcObjectDefinition> @RelatedObjects { get; }
	
	}
}

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IfcRelDecomposes", 306)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcRelDecomposes : IfcRelationship, IIfcRelDecomposes, IEquatable<@IfcRelDecomposes>
	{
		#region IIfcRelDecomposes explicit implementation
		IIfcObjectDefinition IIfcRelDecomposes.RelatingObject { 
 
 
			get { return @RelatingObject; } 
			set { RelatingObject = value as IfcObjectDefinition;}
		}	
		IItemSet<IIfcObjectDefinition> IIfcRelDecomposes.RelatedObjects { 
			get { return new Common.Collections.ProxyItemSet<IfcObjectDefinition, IIfcObjectDefinition>( @RelatedObjects); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDecomposes(IModel model) : base(model) 		{ 
			_relatedObjects = new ItemSet<IfcObjectDefinition>( this, 0,  6);
		}

		#region Explicit attribute fields
		private IfcObjectDefinition _relatingObject;
		private readonly ItemSet<IfcObjectDefinition> _relatedObjects;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcObjectDefinition @RelatingObject 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingObject;
				((IPersistEntity)this).Activate(false);
				return _relatingObject;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingObject = v, _relatingObject, value,  "RelatingObject", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 6)]
		public IItemSet<IfcObjectDefinition> @RelatedObjects 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedObjects;
				((IPersistEntity)this).Activate(false);
				return _relatedObjects;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatingObject = (IfcObjectDefinition)(value.EntityVal);
					return;
				case 5: 
					_relatedObjects.InternalAdd((IfcObjectDefinition)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelDecomposes other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelDecomposes
            var root = (@IfcRelDecomposes)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelDecomposes left, @IfcRelDecomposes right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (ReferenceEquals(left.Model, right.Model));

        }

        public static bool operator !=(@IfcRelDecomposes left, @IfcRelDecomposes right)
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