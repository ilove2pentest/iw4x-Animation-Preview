using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace VideoPlayerApp
{
    public partial class MainWindow : Window
    {
        private List<PersonVideo> people;

        public MainWindow()
        {
            InitializeComponent();

            // Sample data: Replace with your actual video paths
            people = new List<PersonVideo>
                {
                    new PersonVideo { Name = "Airport Anims", VideoPath = @"C:\Mw2AnimPreview\VideoDump\Airport.mp4" },
                    new PersonVideo { Name = "HelicopterPilot2TwitchClickPannel", VideoPath = @"C:\Mw2AnimPreview\VideoDump\HelicopterPilot2TwitchClickPannel.mp4" },
                    new PersonVideo { Name = "HelicopterPilot2TwitchLookoutside", VideoPath = @"C:\Mw2AnimPreview\VideoDump\HelicopterPilot2TwitchLookoutside.mp4" },
                    new PersonVideo { Name = "HelicopterPilotTwitchLookback", VideoPath = @"C:\Mw2AnimPreview\VideoDump\HelicopterPilotTwitchLookback.mp4" },
                    new PersonVideo { Name = "LittleBirdAlertIdleGuy2", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdAlertIdleGuy2.mp4" },
                    new PersonVideo { Name = "LittleBirdDismountGuy1", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdDismountGuy1.mp4" },
                    new PersonVideo { Name = "LittleBirdDismountGuy2", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdDismountGuy2.mp4" },
                    new PersonVideo { Name = "LittleBirdMountGuy1", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdMountGuy1.mp4" },
                    new PersonVideo { Name = "LittleBirdCasualIdleGuy2", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdCasualIdleGuy2.mp4" },
                    new PersonVideo { Name = "UnarmedScaredRun", VideoPath = @"C:\Mw2AnimPreview\VideoDump\UnarmedScaredRun.mp4" },
                    new PersonVideo { Name = "CasualCrouchv2Idle", VideoPath = @"C:\Mw2AnimPreview\VideoDump\CasualCrouchv2Idle.mp4" },
                    new PersonVideo { Name = "UnarmedCowercrouchIdleBack", VideoPath = @"C:\Mw2AnimPreview\VideoDump\UnarmedCowercrouchIdleBack.mp4" },
                    new PersonVideo { Name = "UnarmedCrouchIdle1", VideoPath = @"C:\Mw2AnimPreview\VideoDump\UnarmedCrouchIdle1.mp4" },
                    new PersonVideo { Name = "BreachReactBlowbackv1", VideoPath = @"C:\Mw2AnimPreview\VideoDump\BreachReactBlowbackv1.mp4" },
                    new PersonVideo { Name = "CombatJog", VideoPath = @"C:\Mw2AnimPreview\VideoDump\CombatJog.mp4" },
                    new PersonVideo { Name = "ComerstndAlertSignalMoveOut", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ComerstndAlertSignalMoveOut.mp4" },
                    new PersonVideo { Name = "ComerstndAlertSignalStopStayDo", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ComerstndAlertSignalStopStayDo.mp4" },
                    new PersonVideo { Name = "PatrolBoredIdle", VideoPath = @"C:\Mw2AnimPreview\VideoDump\PatrolBoredIdle.mp4" },
                    new PersonVideo { Name = "PatrolBoredWalk2Bored", VideoPath = @"C:\Mw2AnimPreview\VideoDump\PatrolBoredWalk2Bored.mp4" },
                    new PersonVideo { Name = "PatrolJog", VideoPath = @"C:\Mw2AnimPreview\VideoDump\PatrolJog.mp4" },
                    new PersonVideo { Name = "PatrolJog360", VideoPath = @"C:\Mw2AnimPreview\VideoDump\PatrolJog360.mp4" },
                    new PersonVideo { Name = "StandExposedWaveMoveOut", VideoPath = @"C:\Mw2AnimPreview\VideoDump\StandExposedWaveMoveOut.mp4" },
                    new PersonVideo { Name = "CivilianCawl2", VideoPath = @"C:\Mw2AnimPreview\VideoDump\CivilianCawl2.mp4" },
                    new PersonVideo { Name = "CivilianLeaningDeath", VideoPath = @"C:\Mw2AnimPreview\VideoDump\CivilianLeaningDeath.mp4" },
                    new PersonVideo { Name = "LittleBirdAim2PrelandingGuy1", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdAim2PrelandingGuy1.mp4" },
                    new PersonVideo { Name = "LittleBirdAim2PrelandingGuy3", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdAim2PrelandingGuy3.mp4" },
                    new PersonVideo { Name = "LittleBirdAimIdleGuy1", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdAimIdleGuy1.mp4" },
                    new PersonVideo { Name = "LittleBirdAimIdleGuy2", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdAimIdleGuy2.mp4" },
                    new PersonVideo { Name = "LittleBirdAlert2AimGuy2", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdAlert2AimGuy2.mp4" },
                    new PersonVideo { Name = "LittleBirdAlert2AimGuy3", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdAlert2AimGuy3.mp4" },
                    new PersonVideo { Name = "LittleBirdCasualIdleGuy1", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdCasualIdleGuy1.mp4" },
                    new PersonVideo { Name = "LittleBirdCasualIdleGuy3", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdCasualIdleGuy3.mp4" },
                    new PersonVideo { Name = "LittleBirdPrelandingIdleGuy1", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdPrelandingIdleGuy1.mp4" },
                    new PersonVideo { Name = "LittleBirdPrelandingIdleGuy3", VideoPath = @"C:\Mw2AnimPreview\VideoDump\LittleBirdPrelandingIdleGuy3.mp4" },
                    new PersonVideo { Name = "PatrolBoredPatrolwalk", VideoPath = @"C:\Mw2AnimPreview\VideoDump\PatrolBoredPatrolwalk.mp4" },
                    new PersonVideo { Name = "PatrolBoredrunFind", VideoPath = @"C:\Mw2AnimPreview\VideoDump\PatrolBoredrunFind.mp4" },
                    new PersonVideo { Name = "RiotshieldIdle", VideoPath = @"C:\Mw2AnimPreview\VideoDump\RiotshieldIdle.mp4" },
                    new PersonVideo { Name = "AirportCivFearDrop6", VideoPath = @"C:\Mw2AnimPreview\VideoDump\AirportCivFearDrop6.mp4" },
                    new PersonVideo { Name = "AirportSecurityCivRushGuard", VideoPath = @"C:\Mw2AnimPreview\VideoDump\AirportSecurityCivRushGuard.mp4" },
                    new PersonVideo { Name = "BreachReactDeskv5", VideoPath = @"C:\Mw2AnimPreview\VideoDump\BreachReactDeskv5.mp4" },
                    new PersonVideo { Name = "BreachReactDeskv6", VideoPath = @"C:\Mw2AnimPreview\VideoDump\BreachReactDeskv6.mp4" },
                    new PersonVideo { Name = "CasualKillerJogStop", VideoPath = @"C:\Mw2AnimPreview\VideoDump\CasualKillerJogStop.mp4" },
                    new PersonVideo { Name = "CasualKillerWalkShootFAimdown", VideoPath = @"C:\Mw2AnimPreview\VideoDump\CasualKillerWalkShootFAimdown.mp4" },
                    new PersonVideo { Name = "CivilianBriefcaseWalkDodgeRAlt", VideoPath = @"C:\Mw2AnimPreview\VideoDump\CivilianBriefcaseWalkDodgeRAlt.mp4" },
                    new PersonVideo { Name = "CivilianStandIdle", VideoPath = @"C:\Mw2AnimPreview\VideoDump\CivilianStandIdle.mp4" },
                    new PersonVideo { Name = "CornerStandlExplosionB", VideoPath = @"C:\Mw2AnimPreview\VideoDump\CornerStandlExplosionB.mp4" },
                    new PersonVideo { Name = "DcBurningBunkerReact", VideoPath = @"C:\Mw2AnimPreview\VideoDump\DcBurningBunkerReact.mp4" },
                    new PersonVideo { Name = "DcBurningBunkerStumble", VideoPath = @"C:\Mw2AnimPreview\VideoDump\DcBurningBunkerStumble.mp4" },
                    new PersonVideo { Name = "Doorkick2cqbwalk", VideoPath = @"C:\Mw2AnimPreview\VideoDump\Doorkick2cqbwalk.mp4" },
                    new PersonVideo { Name = "ExposedFastGrenadeF2", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ExposedFastGrenadeF2.mp4" },
                    new PersonVideo { Name = "JuggernautSprint", VideoPath = @"C:\Mw2AnimPreview\VideoDump\JuggernautSprint.mp4" },
                    new PersonVideo { Name = "JuggernautWalkf", VideoPath = @"C:\Mw2AnimPreview\VideoDump\JuggernautWalkf.mp4" },
                    new PersonVideo { Name = "PistolSprint", VideoPath = @"C:\Mw2AnimPreview\VideoDump\PistolSprint.mp4" },
                    new PersonVideo { Name = "PistolWalk", VideoPath = @"C:\Mw2AnimPreview\VideoDump\PistolWalk.mp4" },
                    new PersonVideo { Name = "ReactStand2Run180", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ReactStand2Run180.mp4" },
                    new PersonVideo { Name = "RussianSwatVanGuyl1Idle", VideoPath = @"C:\Mw2AnimPreview\VideoDump\RussianSwatVanGuyl1Idle.mp4" },
                    new PersonVideo { Name = "RussianSwatVanGuyl2Getout", VideoPath = @"C:\Mw2AnimPreview\VideoDump\RussianSwatVanGuyl2Getout.mp4" },
                    new PersonVideo { Name = "RussianSwatVanGuyl4Idle", VideoPath = @"C:\Mw2AnimPreview\VideoDump\RussianSwatVanGuyl4Idle.mp4" },
                    new PersonVideo { Name = "RussianSwatVanGuylRunoff", VideoPath = @"C:\Mw2AnimPreview\VideoDump\RussianSwatVanGuylRunoff.mp4" },
                    new PersonVideo { Name = "RussianSwatVanGuyr_runoff", VideoPath = @"C:\Mw2AnimPreview\VideoDump\RussianSwatVanGuyr_runoff.mp4" },
                    new PersonVideo { Name = "RussianSwatVanGuyr1Getout", VideoPath = @"C:\Mw2AnimPreview\VideoDump\RussianSwatVanGuyr1Getout.mp4" },
                    new PersonVideo { Name = "StandExposedWaveHaltV2", VideoPath = @"C:\Mw2AnimPreview\VideoDump\StandExposedWaveHaltV2.mp4" },
                    new PersonVideo { Name = "UazDriverExitIntoStand", VideoPath = @"C:\Mw2AnimPreview\VideoDump\UazDriverExitIntoStand.mp4" },
                    new PersonVideo { Name = "UazPassengerExitIntoStand", VideoPath = @"C:\Mw2AnimPreview\VideoDump\UazPassengerExitIntoStand.mp4" },
                    new PersonVideo { Name = "Oilrig Anims", VideoPath = @"C:\Mw2AnimPreview\VideoDump\Oilrig Anims.mov" },
                    new PersonVideo { Name = "BreachReactDeskV1", VideoPath = @"C:\Mw2AnimPreview\VideoDump\BreachReactDeskV1.mp4" },
                    new PersonVideo { Name = "BreachReactDeskV7", VideoPath = @"C:\Mw2AnimPreview\VideoDump\BreachReactDeskV7.mp4" },
                    new PersonVideo { Name = "BreachReactGuntossV2Guy2", VideoPath = @"C:\Mw2AnimPreview\VideoDump\BreachReactGuntossV2Guy2.mp4" },
                    new PersonVideo { Name = "BreachReactKnifeCharge", VideoPath = @"C:\Mw2AnimPreview\VideoDump\BreachReactKnifeCharge.mp4" },
                    new PersonVideo { Name = "BreachReactPushGuy2", VideoPath = @"C:\Mw2AnimPreview\VideoDump\BreachReactPushGuy2.mp4" },
                    new PersonVideo { Name = "ExecutionKnifeSoldier", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ExecutionKnifeSoldier.mp4" },
                    new PersonVideo { Name = "ExecutionOnknees2Hostage", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ExecutionOnknees2Hostage.mp4" },
                    new PersonVideo { Name = "ExecutionOnknees2HostageSurvives", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ExecutionOnknees2HostageSurvives.mp4" },
                    new PersonVideo { Name = "ExecutionOnknees2Soldier", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ExecutionOnknees2Soldier.mp4" },
                    new PersonVideo { Name = "ExecutionOnkneesHostage", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ExecutionOnkneesHostage.mp4" },
                    new PersonVideo { Name = "ExecutionOnkneesHostageDeath", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ExecutionOnkneesHostageDeath.mp4" },
                    new PersonVideo { Name = "ExecutionOnkneesSoldier", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ExecutionOnkneesSoldier.mp4" },
                    new PersonVideo { Name = "ExecutionShieldHostageSurvives", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ExecutionShieldHostageSurvives.mp4" },
                    new PersonVideo { Name = "ExecutionShieldSoldier", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ExecutionShieldSoldier.mp4" },
                    new PersonVideo { Name = "ExecutionSlamwallHostageDeath", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ExecutionSlamwallHostageDeath.mp4" },
                    new PersonVideo { Name = "ExplosivePlantKnee", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ExplosivePlantKnee.mp4" },
                    new PersonVideo { Name = "HostageChairTwitch", VideoPath = @"C:\Mw2AnimPreview\VideoDump\HostageChairTwitch.mp4" },
                    new PersonVideo { Name = "HostageChairTwitch2", VideoPath = @"C:\Mw2AnimPreview\VideoDump\HostageChairTwitch2.mp4" },
                    new PersonVideo { Name = "HostageStandFall", VideoPath = @"C:\Mw2AnimPreview\VideoDump\HostageStandFall.mp4" },
                    new PersonVideo { Name = "HuntedDive2PronehideV1", VideoPath = @"C:\Mw2AnimPreview\VideoDump\HuntedDive2PronehideV1.mp4" },
                    new PersonVideo { Name = "HuntedPronehide2StandV1", VideoPath = @"C:\Mw2AnimPreview\VideoDump\HuntedPronehide2StandV1.mp4" },
                    new PersonVideo { Name = "oilrigHelpout2", VideoPath = @"C:\Mw2AnimPreview\VideoDump\oilrigHelpout2.mp4" },
                    new PersonVideo { Name = "OilrigSealSurfaceMaskOff", VideoPath = @"C:\Mw2AnimPreview\VideoDump\OilrigSealSurfaceMaskOff.mp4" },
                    new PersonVideo { Name = "OilrigSealSurfaceRebreatherOffGuy1", VideoPath = @"C:\Mw2AnimPreview\VideoDump\OilrigSealSurfaceRebreatherOffGuy1.mp4" },
                    new PersonVideo { Name = "oilrigUnderwaterGuard2Death", VideoPath = @"C:\Mw2AnimPreview\VideoDump\oilrigUnderwaterGuard2Death.mp4" },
                    new PersonVideo { Name = "oilrigUnderwaterGuard2Idle", VideoPath = @"C:\Mw2AnimPreview\VideoDump\oilrigUnderwaterGuard2Idle.mp4" },
                    new PersonVideo { Name = "ParabloicLeaningGuyReact", VideoPath = @"C:\Mw2AnimPreview\VideoDump\ParabloicLeaningGuyReact.mp4" },
                    new PersonVideo { Name = "PrisonerPickup2runSolider", VideoPath = @"C:\Mw2AnimPreview\VideoDump\PrisonerPickup2runSolider.mp4" },
                    new PersonVideo { Name = "PrisonerPickup2walkSoldier", VideoPath = @"C:\Mw2AnimPreview\VideoDump\PrisonerPickup2walkSoldier.mp4" },
                    new PersonVideo { Name = "TakedownRoom1aHostageB", VideoPath = @"C:\Mw2AnimPreview\VideoDump\TakedownRoom1aHostageB.mp4" },
                    new PersonVideo { Name = "TakedownRoom1aHostageBIdle", VideoPath = @"C:\Mw2AnimPreview\VideoDump\TakedownRoom1aHostageBIdle.mp4" },
                    new PersonVideo { Name = "TakedownRoom1bHostage", VideoPath = @"C:\Mw2AnimPreview\VideoDump\TakedownRoom1bHostage.mp4" },
                    new PersonVideo { Name = "TakedownRoom1bHostageIdle", VideoPath = @"C:\Mw2AnimPreview\VideoDump\TakedownRoom1bHostageIdle.mp4" },
                    new PersonVideo { Name = "TakedownRoom2aHostageaHideIdle", VideoPath = @"C:\Mw2AnimPreview\VideoDump\TakedownRoom2aHostageaHideIdle.mp4" },
                    new PersonVideo { Name = "TakedownRoom2aHostageBStartIdle", VideoPath = @"C:\Mw2AnimPreview\VideoDump\TakedownRoom2aHostageBStartIdle.mp4" },
                    new PersonVideo { Name = "TakedownRoom2aSoldier", VideoPath = @"C:\Mw2AnimPreview\VideoDump\TakedownRoom2aSoldier.mp4" },
                    new PersonVideo { Name = "TakedownRoom2bHostageAidle", VideoPath = @"C:\Mw2AnimPreview\VideoDump\TakedownRoom2bHostageAidle.mp4" },
                    new PersonVideo { Name = "TakedownRoom2bhostageb", VideoPath = @"C:\Mw2AnimPreview\VideoDump\TakedownRoom2bhostageb.mp4" },
                    new PersonVideo { Name = "TakedownRoom2bSoldier", VideoPath = @"C:\Mw2AnimPreview\VideoDump\TakedownRoom2bSoldier.mp4" },
                };

            NamesListBox.ItemsSource = people;
        }

        private void NamesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NamesListBox.SelectedItem is PersonVideo selectedPerson)
            {
                try
                {
                    VideoPlayer.Source = new Uri(selectedPerson.VideoPath, UriKind.RelativeOrAbsolute);
                    VideoPlayer.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error playing video: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void VideoPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            VideoPlayer.Position = TimeSpan.Zero;
            VideoPlayer.Play();
        }
    }

    public class PersonVideo
    {
        public string Name { get; set; }
        public string VideoPath { get; set; }
    }
}