using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClupManagementDataAccessLayer;

namespace ClubManagement
{
    public class BindingHelpers
    {
        // ================================
        // 🔹 BindingListEx مخصصة
        // ================================
        public class BindingListEx<T> : BindingList<T>, ITypedList
        {
            public BindingListEx(IList<T> list) : base(list) { }

            public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
            {
                var props = new List<PropertyDescriptor>();

                foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(typeof(T)))
                {
                    if (prop.Name == "GetTableDTO")
                        continue;
                    //if (prop.PropertyType == typeof(Table_Fess))
                    //{
                    //    var subProps = TypeDescriptor.GetProperties(prop.PropertyType);
                    //    foreach (PropertyDescriptor subProp in subProps)
                    //    {
                    //        if (subProp.Name == "FeesByHour" || subProp.Name == "FeesByMatch")
                    //            props.Add(new SubPropertyDescriptor(prop, subProp));
                    //    }
                    //}
                    //else
                    //{
                    //    props.Add(prop);
                    //}
                }
                return new PropertyDescriptorCollection(props.ToArray());
            }

            public string GetListName(PropertyDescriptor[] listAccessors) => typeof(T).Name;
        }

        public class SubPropertyDescriptor : PropertyDescriptor
        {
            private PropertyDescriptor parent;
            private PropertyDescriptor child;

            public SubPropertyDescriptor(PropertyDescriptor parent, PropertyDescriptor child)
                : base(parent.Name + "." + child.Name, null)
            {
                this.parent = parent;
                this.child = child;
            }

            public override bool CanResetValue(object component) => false;
            public override Type ComponentType => parent.ComponentType;
            public override object GetValue(object component)
            {
                var parentValue = parent.GetValue(component);
                return parentValue == null ? null : child.GetValue(parentValue);
            }
            public override bool IsReadOnly => true;
            public override Type PropertyType => child.PropertyType;
            public override void ResetValue(object component) { }
            public override void SetValue(object component, object value) { }
            public override bool ShouldSerializeValue(object component) => false;
        }
    }

}

