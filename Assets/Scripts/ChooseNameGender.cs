using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class ChooseNameGender {
  [FormerlySerializedAs("chooseNameGenderView")] [SerializeField] private ChooseNameGenderView view;
  
  public event Action<Gender> ChooseAvatarEvent;
  public event Action<string> EndEditNameEvent;
  public event Action DoneEvent;


  public void Initialize() {
    view.Open();
    view.ChooseAvatarEvent += gender => ChooseAvatarEvent?.Invoke(gender); 
    view.EndEditNameEvent += name => EndEditNameEvent?.Invoke(name);
    view.DoneEvent += () => { DoneEvent?.Invoke(); };
  }

  public void OpenView()
  {
    view.Open();
  }

  public void CloseView()
  {
    view.Close();
  }
  
}
