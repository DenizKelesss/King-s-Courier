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
    [CreateAssetMenu(fileName="ArticyGlobalVariables", menuName="Create GlobalVariables", order=620)]
    public class ArticyGlobalVariables : BaseGlobalVariables
    {
        
        [SerializeField()]
        [HideInInspector()]
        private Objectives mObjectives = new Objectives();
        
        [SerializeField()]
        [HideInInspector()]
        private FallGate mFallGate = new FallGate();
        
        [SerializeField()]
        [HideInInspector()]
        private Scene1Objectives mScene1Objectives = new Scene1Objectives();
        
        [SerializeField()]
        [HideInInspector()]
        private KingdomReputation mKingdomReputation = new KingdomReputation();
        
        [SerializeField()]
        [HideInInspector()]
        private VOTriggers mVOTriggers = new VOTriggers();
        
        [SerializeField()]
        [HideInInspector()]
        private DialogueOptions mDialogueOptions = new DialogueOptions();
        
        [SerializeField()]
        [HideInInspector()]
        private EventTriggers mEventTriggers = new EventTriggers();
        
        [SerializeField()]
        [HideInInspector()]
        private Scene1Finishing mScene1Finishing = new Scene1Finishing();
        
        #region Initialize static VariableName set
        static ArticyGlobalVariables()
        {
            variableNames.Add("Objectives.PressEtoTalk");
            variableNames.Add("Objectives.OpenGate");
            variableNames.Add("Objectives.Understand");
            variableNames.Add("Objectives.TalkToLadyU");
            variableNames.Add("FallGate.FallGateOpen");
            variableNames.Add("Scene1Objectives.TalkToSentryGuard");
            variableNames.Add("Scene1Objectives.TalkToKing");
            variableNames.Add("KingdomReputation.KingdomRep");
            variableNames.Add("VOTriggers.Scene1Line1");
            variableNames.Add("VOTriggers.Scene1Line2");
            variableNames.Add("DialogueOptions.SadKidOpt1");
            variableNames.Add("DialogueOptions.SadKidRegOpt1Visited");
            variableNames.Add("DialogueOptions.SadKidRegOpt2Visited");
            variableNames.Add("DialogueOptions.Philippe1OptsVisited");
            variableNames.Add("DialogueOptions.Philippe2_1OptVisited");
            variableNames.Add("DialogueOptions.Philippe2_2OptVisited");
            variableNames.Add("DialogueOptions.Philippe2_3OptVisited");
            variableNames.Add("DialogueOptions.Philippe2_2_1OptVisited");
            variableNames.Add("DialogueOptions.MomArgueOpt1Visited");
            variableNames.Add("DialogueOptions.CaptainVisited");
            variableNames.Add("DialogueOptions.DrunkLadyOpt1Visited");
            variableNames.Add("DialogueOptions.PeasantOpt1Visited");
            variableNames.Add("EventTriggers.CultistLadyRun");
            variableNames.Add("EventTriggers.CultistLadyGone");
            variableNames.Add("Scene1Finishing.CultLadyDone");
            variableNames.Add("Scene1Finishing.LordPhilppeDone");
        }
        #endregion
        
        public Objectives Objectives
        {
            get
            {
                return mObjectives;
            }
        }
        
        public FallGate FallGate
        {
            get
            {
                return mFallGate;
            }
        }
        
        public Scene1Objectives Scene1Objectives
        {
            get
            {
                return mScene1Objectives;
            }
        }
        
        public KingdomReputation KingdomReputation
        {
            get
            {
                return mKingdomReputation;
            }
        }
        
        public VOTriggers VOTriggers
        {
            get
            {
                return mVOTriggers;
            }
        }
        
        public DialogueOptions DialogueOptions
        {
            get
            {
                return mDialogueOptions;
            }
        }
        
        public EventTriggers EventTriggers
        {
            get
            {
                return mEventTriggers;
            }
        }
        
        public Scene1Finishing Scene1Finishing
        {
            get
            {
                return mScene1Finishing;
            }
        }
        
        public static ArticyGlobalVariables Default
        {
            get
            {
                return ((ArticyGlobalVariables)(Articy.Unity.ArticyDatabase.DefaultGlobalVariables));
            }
        }
        
        public override void Init()
        {
            Objectives.RegisterVariables(this);
            FallGate.RegisterVariables(this);
            Scene1Objectives.RegisterVariables(this);
            KingdomReputation.RegisterVariables(this);
            VOTriggers.RegisterVariables(this);
            DialogueOptions.RegisterVariables(this);
            EventTriggers.RegisterVariables(this);
            Scene1Finishing.RegisterVariables(this);
        }
        
        public static ArticyGlobalVariables CreateGlobalVariablesClone()
        {
            return Articy.Unity.BaseGlobalVariables.CreateGlobalVariablesClone<ArticyGlobalVariables>();
        }
    }
}
