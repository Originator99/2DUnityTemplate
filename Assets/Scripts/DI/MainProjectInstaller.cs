using Zenject;
using UnityEngine;
using System;
public class MainProjectInstaller : MonoInstaller {
    public override void InstallBindings() {
        Debug.Log("Project Installer Initialized");
    }
}
