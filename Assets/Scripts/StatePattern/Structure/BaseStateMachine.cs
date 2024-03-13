using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

namespace StatePattern.Structure
{
    public abstract class BaseStateMachine
    {

        #region Constructor

        protected BaseStateMachine(IStateMachineHandler handler = null) => Handler = handler;

        #endregion

        #region Properties

        
        public bool IsInitialize { get; protected set; }
        
        //Stack of states
        private readonly Stack<IState> stack = new Stack<IState>();
        
        // this register does not allow the FSM to have two states with the same type
        readonly Dictionary<Type, IState> register = new Dictionary<Type, IState>();
        
        public IStateMachineHandler Handler { get; set; }
        
        // returns the state on the top of the stack. Can be null.

        public IState Current => PeekState();

        #endregion

        #region Initialization

        public void RegisterState(IState state)
        {
            if(state == null)
                throw new ArgumentNullException(nameof(state));

            var type = state.GetType();
            register.Add(type,state);
        }
        
        // Initialize all states. All states have to be registered before the initialization.

        public void Initialize()
        {
            OnBeforeInitialize();

            foreach (var state in register.Values)
            {
                state.OnInitialize();
                
            }
            IsInitialize = true;
            OnAfterInitialize();
        }
        
        // create and register the states overriding this method. It happens right before the initialization.
        protected virtual void OnBeforeInitialize() { }
        
        // this method is called after the initialization. Override this methods when need it.
        protected virtual void OnAfterInitialize() { }
        
        public void Update() => Current?.OnUpdate();

        
        // bool result = IsCurrent<ConcreteState>();
        public bool IsCurrent<T>() where T : IState => Current?.GetType() == typeof(T);

        // bool result = IsCurrent(new ConcreteState());
        public bool IsCurrent(IState state)
        {
            if(state == null)
                throw new ArgumentNullException(nameof(state));
            
            return Current?.GetType() == state.GetType();
        }
        
        // pushes a state by type
        public void PushState<T>(bool isSilent = false) where T : IState
        {
            var stateType = typeof(T);
            var state = register[stateType];
            PushState(state,isSilent);
        }
        
        // pushes a state by instance of the class
        public void PushState(IState state, bool isSilent = false)
        {
            var type = state.GetType();
            if (!register.ContainsKey(type))
                throw new ArgumentException($"State {type.Name} is not registered");
            
            if(stack.Count>0 && !isSilent)
                Current?.OnExitState();
            
            stack.Push(state);
            state.OnEnterState();
        }
        
        public IState PeekState() => stack.Count > 0 ? stack.Peek() : null;

        public void PopState(bool isSilent = false)
        {
            if(Current == null)
                return;

            var state = stack.Pop();
            state.OnExitState();
            
            if(!isSilent)
                Current?.OnEnterState();

        }

        public virtual void Clear()
        {
            foreach (var states in register.Values)
            {
                states.OnClear();
                
            }
            stack.Clear();
            register.Clear();
        }

        #endregion

    }
}