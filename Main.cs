using BoneLib;
using MelonLoader;

namespace bonelab_template // Must change this to the name of your mod or has a very High chance of causing issues!!!
{
    internal partial class Main : MelonMod
    {
        public const string ModName = "Mod Name"; // Change this to the name of your mod

        public override void OnEarlyInitializeMelon()
        {
            base.OnEarlyInitializeMelon();
        }

        public override void OnInitializeMelon()
        {
            base.OnInitializeMelon();
            
            Hooking.OnLevelInitialized += _ => { OnSceneAwake(); }; // This will call the OnSceneAwake() method in Main.cs when the level is initialized
            Preferences.MelonPreferencesCreator(); // This will call the MelonPreferencesCreator() method in Preferences.cs
            Preferences.BoneMenuCreator(); // This will call the BoneMenuCreator() method in Preferences.cs
        }

        public override void OnLateInitializeMelon()
        {
            base.OnLateInitializeMelon();
        }
        
        public static void OnSceneAwake()
        {
            
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
        }

        public override void OnFixedUpdate()
        {
            base.OnFixedUpdate();
        }

        public override void OnLateUpdate()
        {
            base.OnLateUpdate();
        }
    }
}
