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
using UnityEngine;


namespace Articy.King_s_Courier.GlobalVariables
{
    
    
    [Serializable()]
    public class Objectives : IArticyNamespace
    {
        
        [SerializeField()]
        private BaseGlobalVariables _VariableStorage;
        
        // 
        public bool PressEtoTalk
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(0);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(0, value);
            }
        }
        
        // 
        public bool OpenGate
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(1);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(1, value);
            }
        }
        
        // 
        public bool Understand
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(2);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(2, value);
            }
        }
        
        // 
        public bool TalkToLadyU
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(3);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(3, value);
            }
        }
        
        public void RegisterVariables(BaseGlobalVariables aStorage)
        {
            _VariableStorage = aStorage;
            aStorage.RegisterVariable("Objectives.PressEtoTalk", false);
            aStorage.RegisterVariable("Objectives.OpenGate", false);
            aStorage.RegisterVariable("Objectives.Understand", false);
            aStorage.RegisterVariable("Objectives.TalkToLadyU", false);
        }
    }
}
namespace Articy.King_s_Courier.GlobalVariables
{
    
    
    [Serializable()]
    public class FallGate : IArticyNamespace
    {
        
        [SerializeField()]
        private BaseGlobalVariables _VariableStorage;
        
        // 
        public bool FallGateOpen
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(4);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(4, value);
            }
        }
        
        public void RegisterVariables(BaseGlobalVariables aStorage)
        {
            _VariableStorage = aStorage;
            aStorage.RegisterVariable("FallGate.FallGateOpen", false);
        }
    }
}
namespace Articy.King_s_Courier.GlobalVariables
{
    
    
    [Serializable()]
    public class Scene1Objectives : IArticyNamespace
    {
        
        [SerializeField()]
        private BaseGlobalVariables _VariableStorage;
        
        // 
        public bool TalkToSentryGuard
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(5);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(5, value);
            }
        }
        
        // 
        public bool TalkToKing
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(6);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(6, value);
            }
        }
        
        public void RegisterVariables(BaseGlobalVariables aStorage)
        {
            _VariableStorage = aStorage;
            aStorage.RegisterVariable("Scene1Objectives.TalkToSentryGuard", false);
            aStorage.RegisterVariable("Scene1Objectives.TalkToKing", false);
        }
    }
}
namespace Articy.King_s_Courier.GlobalVariables
{
    
    
    [Serializable()]
    public class KingdomReputation : IArticyNamespace
    {
        
        [SerializeField()]
        private BaseGlobalVariables _VariableStorage;
        
        // 
        public int KingdomRep
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueInt32(0);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueInt32(0, value);
            }
        }
        
        public void RegisterVariables(BaseGlobalVariables aStorage)
        {
            _VariableStorage = aStorage;
            aStorage.RegisterVariable("KingdomReputation.KingdomRep", 50);
        }
    }
}
namespace Articy.King_s_Courier.GlobalVariables
{
    
    
    [Serializable()]
    public class VOTriggers : IArticyNamespace
    {
        
        [SerializeField()]
        private BaseGlobalVariables _VariableStorage;
        
        // 
        public bool Scene1Line1
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(7);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(7, value);
            }
        }
        
        // 
        public bool Scene1Line2
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(8);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(8, value);
            }
        }
        
        public void RegisterVariables(BaseGlobalVariables aStorage)
        {
            _VariableStorage = aStorage;
            aStorage.RegisterVariable("VOTriggers.Scene1Line1", false);
            aStorage.RegisterVariable("VOTriggers.Scene1Line2", false);
        }
    }
}
namespace Articy.King_s_Courier.GlobalVariables
{
    
    
    [Serializable()]
    public class DialogueOptions : IArticyNamespace
    {
        
        [SerializeField()]
        private BaseGlobalVariables _VariableStorage;
        
        // 
        public bool SadKidOpt1
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(9);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(9, value);
            }
        }
        
        // 
        public bool SadKidRegOpt1Visited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(10);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(10, value);
            }
        }
        
        // 
        public bool SadKidRegOpt2Visited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(11);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(11, value);
            }
        }
        
        // 
        public bool Philippe1OptsVisited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(12);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(12, value);
            }
        }
        
        // 
        public bool Philippe2_1OptVisited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(13);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(13, value);
            }
        }
        
        // 
        public bool Philippe2_2OptVisited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(14);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(14, value);
            }
        }
        
        // 
        public bool Philippe2_3OptVisited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(15);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(15, value);
            }
        }
        
        // 
        public bool Philippe2_2_1OptVisited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(16);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(16, value);
            }
        }
        
        // 
        public bool MomArgueOpt1Visited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(17);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(17, value);
            }
        }
        
        // 
        public bool CaptainVisited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(18);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(18, value);
            }
        }
        
        // 
        public bool DrunkLadyOpt1Visited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(19);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(19, value);
            }
        }
        
        // 
        public bool PeasantOpt1Visited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(20);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(20, value);
            }
        }
        
        // 
        public bool ProtoGuyOpt1Visited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(21);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(21, value);
            }
        }
        
        // 
        public bool Philippe1_1OptVisited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(22);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(22, value);
            }
        }
        
        // 
        public bool Philippe1_2OptVisited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(23);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(23, value);
            }
        }
        
        // 
        public bool CultLadyTriggerDialogueVisited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(24);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(24, value);
            }
        }
        
        // 
        public bool PeasantOpt2Visited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(25);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(25, value);
            }
        }
        
        // 
        public bool GateGuardOp1Visited
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(26);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(26, value);
            }
        }
        
        // 
        public bool CaptainVisited2
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(27);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(27, value);
            }
        }
        
        // 
        public bool CaptainVisited3
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(28);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(28, value);
            }
        }
        
        public void RegisterVariables(BaseGlobalVariables aStorage)
        {
            _VariableStorage = aStorage;
            aStorage.RegisterVariable("DialogueOptions.SadKidOpt1", true);
            aStorage.RegisterVariable("DialogueOptions.SadKidRegOpt1Visited", false);
            aStorage.RegisterVariable("DialogueOptions.SadKidRegOpt2Visited", false);
            aStorage.RegisterVariable("DialogueOptions.Philippe1OptsVisited", false);
            aStorage.RegisterVariable("DialogueOptions.Philippe2_1OptVisited", false);
            aStorage.RegisterVariable("DialogueOptions.Philippe2_2OptVisited", false);
            aStorage.RegisterVariable("DialogueOptions.Philippe2_3OptVisited", false);
            aStorage.RegisterVariable("DialogueOptions.Philippe2_2_1OptVisited", false);
            aStorage.RegisterVariable("DialogueOptions.MomArgueOpt1Visited", false);
            aStorage.RegisterVariable("DialogueOptions.CaptainVisited", false);
            aStorage.RegisterVariable("DialogueOptions.DrunkLadyOpt1Visited", false);
            aStorage.RegisterVariable("DialogueOptions.PeasantOpt1Visited", false);
            aStorage.RegisterVariable("DialogueOptions.ProtoGuyOpt1Visited", false);
            aStorage.RegisterVariable("DialogueOptions.Philippe1_1OptVisited", false);
            aStorage.RegisterVariable("DialogueOptions.Philippe1_2OptVisited", false);
            aStorage.RegisterVariable("DialogueOptions.CultLadyTriggerDialogueVisited", false);
            aStorage.RegisterVariable("DialogueOptions.PeasantOpt2Visited", false);
            aStorage.RegisterVariable("DialogueOptions.GateGuardOp1Visited", false);
            aStorage.RegisterVariable("DialogueOptions.CaptainVisited2", false);
            aStorage.RegisterVariable("DialogueOptions.CaptainVisited3", false);
        }
    }
}
namespace Articy.King_s_Courier.GlobalVariables
{
    
    
    [Serializable()]
    public class EventTriggers : IArticyNamespace
    {
        
        [SerializeField()]
        private BaseGlobalVariables _VariableStorage;
        
        // 
        public bool CultistLadyRun
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(29);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(29, value);
            }
        }
        
        // 
        public bool CultistLadyGone
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(30);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(30, value);
            }
        }
        
        public void RegisterVariables(BaseGlobalVariables aStorage)
        {
            _VariableStorage = aStorage;
            aStorage.RegisterVariable("EventTriggers.CultistLadyRun", false);
            aStorage.RegisterVariable("EventTriggers.CultistLadyGone", false);
        }
    }
}
namespace Articy.King_s_Courier.GlobalVariables
{
    
    
    [Serializable()]
    public class Scene1Finishing : IArticyNamespace
    {
        
        [SerializeField()]
        private BaseGlobalVariables _VariableStorage;
        
        // 
        public bool CultLadyDone
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(31);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(31, value);
            }
        }
        
        // 
        public bool LordPhilppeDone
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(32);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(32, value);
            }
        }
        
        public void RegisterVariables(BaseGlobalVariables aStorage)
        {
            _VariableStorage = aStorage;
            aStorage.RegisterVariable("Scene1Finishing.CultLadyDone", false);
            aStorage.RegisterVariable("Scene1Finishing.LordPhilppeDone", false);
        }
    }
}
