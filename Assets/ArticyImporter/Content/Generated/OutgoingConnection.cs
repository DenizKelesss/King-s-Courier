//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Articy.King_s_Courier
{
    
    
    [Serializable()]
    public class OutgoingConnection : IArticyBaseObject, IOutgoingConnection, IObjectWithColor, IObjectWithTarget
    {
        
        [SerializeField()]
        private ArticyValueArticyString mLabel = new ArticyValueArticyString();
        
        [SerializeField()]
        private Color mColor;
        
        [SerializeField()]
        private UInt64 mTargetPin;
        
        [SerializeField()]
        private ArticyValueArticyObject mTarget = new ArticyValueArticyObject();
        
        public ArticyString Label
        {
            get
            {
                return mLabel.GetValue();
            }
            set
            {
                mLabel.SetValue(value);
            }
        }
        
        public Color Color
        {
            get
            {
                return mColor;
            }
            set
            {
                mColor = value;
            }
        }
        
        public UInt64 TargetPin
        {
            get
            {
                return mTargetPin;
            }
            set
            {
                mTargetPin = value;
            }
        }
        
        public ArticyObject Target
        {
            get
            {
                return mTarget.GetValue();
            }
            set
            {
                mTarget.SetValue(value);
            }
        }
        
        private void CloneProperties(object aClone, Articy.Unity.ArticyObject aFirstClassParent)
        {
            OutgoingConnection newClone = ((OutgoingConnection)(aClone));
            if ((mLabel != null))
            {
                newClone.mLabel = ((ArticyValueArticyString)(mLabel.CloneObject(newClone, aFirstClassParent)));
            }
            newClone.Color = Color;
            newClone.TargetPin = TargetPin;
            if ((mTarget != null))
            {
                newClone.mTarget = ((ArticyValueArticyObject)(mTarget.CloneObject(newClone, aFirstClassParent)));
            }
        }
        
        public object CloneObject(object aParent, Articy.Unity.ArticyObject aFirstClassParent)
        {
            OutgoingConnection clone = new OutgoingConnection();
            CloneProperties(clone, aFirstClassParent);
            return clone;
        }
    }
}
