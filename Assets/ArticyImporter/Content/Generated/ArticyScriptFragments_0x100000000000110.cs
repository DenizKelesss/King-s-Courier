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


namespace Articy.King_s_Courier.GlobalVariables
{
    
    
    public partial class ArticyScriptFragments : BaseScriptFragments, ISerializationCallbackReceiver
    {
        
        #region Script fragments
        /// <summary>
        /// ObjectID: 0x1000000000002CE
        /// Articy Object ref: articy://localhost/view/f0d0e3ed-90fe-43ac-8d88-8ad8ef9a5834/72057594037928654?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_720575940379282080x1000000000002CEExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.DialogueOptions.SadKidOpt1;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000154
        /// Articy Object ref: articy://localhost/view/f0d0e3ed-90fe-43ac-8d88-8ad8ef9a5834/72057594037928276?pane=selected&amp;tab=current
        /// </summary>
        public void Script_720575940379282080x100000000000154Expression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.FallGate.FallGateOpen = true;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000015F
        /// Articy Object ref: articy://localhost/view/f0d0e3ed-90fe-43ac-8d88-8ad8ef9a5834/72057594037928287?pane=selected&amp;tab=current
        /// </summary>
        public void Script_720575940379282080x10000000000015FExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.KingdomReputation.KingdomRep = 60;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000235
        /// Articy Object ref: articy://localhost/view/f0d0e3ed-90fe-43ac-8d88-8ad8ef9a5834/72057594037928501?pane=selected&amp;tab=current
        /// </summary>
        public void Script_720575940379282080x100000000000235Expression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.VOTriggers.Scene1Line1 = true;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000024B
        /// Articy Object ref: articy://localhost/view/f0d0e3ed-90fe-43ac-8d88-8ad8ef9a5834/72057594037928523?pane=selected&amp;tab=current
        /// </summary>
        public void Script_720575940379282080x10000000000024BExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.VOTriggers.Scene1Line2 = true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000002DC
        /// Articy Object ref: articy://localhost/view/f0d0e3ed-90fe-43ac-8d88-8ad8ef9a5834/72057594037928668?pane=selected&amp;tab=current
        /// </summary>
        public void Script_720575940379282080x1000000000002DCExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.DialogueOptions.SadKidOpt1 = false;
        }
        #endregion
        
        #region Unity serialization
        public virtual void OnAfterDeserialize_0x100000000000110()
        {
            Conditions.Add(3880432021u, this.Script_720575940379282080x1000000000002CEExpression);
            Instructions.Add(101404872u, this.Script_720575940379282080x100000000000154Expression);
            Instructions.Add(799694506u, this.Script_720575940379282080x10000000000015FExpression);
            Instructions.Add(515138219u, this.Script_720575940379282080x100000000000235Expression);
            Instructions.Add(2526110314u, this.Script_720575940379282080x10000000000024BExpression);
            Instructions.Add(2380061437u, this.Script_720575940379282080x1000000000002DCExpression);
        }
        #endregion
    }
}
