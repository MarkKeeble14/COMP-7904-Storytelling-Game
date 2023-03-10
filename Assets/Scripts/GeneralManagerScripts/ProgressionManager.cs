using System.Collections.Generic;
using UnityEngine;
using System;

public class ProgressionManager : MonoBehaviour
{
    // Make a singleton for easy access
    public static ProgressionManager _Instance;
    private void Awake()
    {
        if (_Instance != null)
        {
            Destroy(_Instance);
        }
        _Instance = this;
    }

    private bool jetpackUnlocked;
    private bool flamethrowerUnlocked;

    private List<UnlockType> currentUnlocks = new List<UnlockType>();

    private bool laserCutterUnlocked;
    private bool pulseGrenadeLauncherUnlocked;

    [Header("Settings")]
    [SerializeField] private bool unlockAllOnStart;
    [SerializeField] private float unlockTextDuration = 3f;

    [SerializeField] private RadialMenu weaponAttachmentMenu;
    [SerializeField] private GameObject currentWeaponAttachmentDisplay;
    [SerializeField] private GameObject fuelDisplay;

    [Header("Jetpack")]
    [SerializeField] private PlayerController playerController;
    [SerializeField] private GameObject hasJetpackIcon;
    [SerializeField] private GameObject jetpackSliderBar;

    [Header("Flamethrower")]
    [SerializeField] private GameObject flamethrowerCrosshair;
    [SerializeField] private RadialMenuButton flamethrowerButton;

    [Header("Laser Cutter")]
    [SerializeField] private GameObject laserCutterCrosshair;
    [SerializeField] private RadialMenuButton laserCutterButton;

    [Header("Pulse Grenade Launcher")]
    [SerializeField] private GameObject pulseGrenadeLauncherCrosshair;
    [SerializeField] private RadialMenuButton pulseGrenadeLauncherButton;

    private void Start()
    {
        // Unlock everything on awake for testing
        if (unlockAllOnStart)
        {
            UnlockAll();
        }
    }

    [ContextMenu("Unlock/Jetpack")]
    public void UnlockJetpack()
    {
        if (jetpackUnlocked) return;
        jetpackUnlocked = true;

        // Set fuel display to be active
        fuelDisplay.SetActive(true);

        jetpackSliderBar.SetActive(true);

        // Turn on icon so player knows they have jetpack
        // hasJetpackIcon.SetActive(true);

        // Allow player to use jetpack
        playerController.AquireJetpack();

        currentUnlocks.Add(UnlockType.JETPACK);

        GameManager._Instance.PlayerUseFuel = true;

        // Spawn text
        TextPopupManager._Instance.SpawnText("Jetpack\nPress space when in the air to fly", unlockTextDuration);
    }

    [ContextMenu("Unlock/Flamethrower")]
    public void UnlockFlamethrower()
    {
        if (flamethrowerUnlocked) return;
        flamethrowerUnlocked = true;

        // Set fuel display to be active
        fuelDisplay.SetActive(true);

        // Set weapon display to be active
        currentWeaponAttachmentDisplay.SetActive(true);

        // Add and select new attachment
        weaponAttachmentMenu.AddButtion(flamethrowerButton);
        weaponAttachmentMenu.SetButton(flamethrowerButton);

        // Enable crosshair
        flamethrowerCrosshair.gameObject.SetActive(true);

        currentUnlocks.Add(UnlockType.FLAMETHROWER);

        GameManager._Instance.PlayerUseFuel = true;

        // Spawn text
        TextPopupManager._Instance.SpawnText("Unlocked the Flamethrower\nHold Tab to Select, Hold Q to Use\nBurn travelling flesh to prevent other enemies from getting stronger", unlockTextDuration + 5f);
    }

    [ContextMenu("Unlock/LaserCutter")]
    public void UnlockLaserCutter()
    {
        if (laserCutterUnlocked) return;
        laserCutterUnlocked = true;

        // Set weapon display to be active
        currentWeaponAttachmentDisplay.SetActive(true);

        // Add and select new attachment
        weaponAttachmentMenu.AddButtion(laserCutterButton);
        weaponAttachmentMenu.SetButton(laserCutterButton);

        // Enable crosshair
        laserCutterCrosshair.gameObject.SetActive(true);

        currentUnlocks.Add(UnlockType.LASER_CUTTER);

        // Spawn text
        TextPopupManager._Instance.SpawnText("Unlocked the Laser Cutter\nYou can now laser through certain materials", unlockTextDuration);
    }

    [ContextMenu("Unlock/PulseGrenadeLauncher")]
    public void UnlockPulseGrenadeLauncher()
    {
        if (pulseGrenadeLauncherUnlocked) return;
        pulseGrenadeLauncherUnlocked = true;

        // Set weapon display to be active
        currentWeaponAttachmentDisplay.SetActive(true);

        // Add and select new attachment
        weaponAttachmentMenu.AddButtion(pulseGrenadeLauncherButton);
        weaponAttachmentMenu.SetButton(pulseGrenadeLauncherButton);

        // Enable crosshair
        pulseGrenadeLauncherCrosshair.gameObject.SetActive(true);

        currentUnlocks.Add(UnlockType.PULSE_GRENADE_LAUNCHER);

        // Spawn text
        TextPopupManager._Instance.SpawnText("Pulse Grenade Launcher\nArea of effect damage", unlockTextDuration);
    }

    [ContextMenu("Unlock/All")]
    private void UnlockAll()
    {
        UnlockJetpack();
        UnlockFlamethrower();
        UnlockLaserCutter();
        UnlockPulseGrenadeLauncher();
    }

    public bool HasAllUnlocks(List<UnlockType> requiredUnlocks)
    {
        foreach (UnlockType type in requiredUnlocks)
        {
            if (!currentUnlocks.Contains(type)) return false;
        }
        return true;
    }
}
