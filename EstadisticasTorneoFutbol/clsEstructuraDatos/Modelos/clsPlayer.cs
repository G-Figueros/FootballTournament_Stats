using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEstructuraDatos.Modelos
{
    public class clsPlayer
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Birthday { get; set; }
        public string BirthdayGMT { get; set; }
        public string League { get; set; }
        public string Season { get; set; }
        public string Position { get; set; }
        public string CurrentClub { get; set; }
        public int MinutesPlayedOverall { get; set; }
        public int MinutesPlayedHome { get; set; }
        public int MinutesPlayedAway { get; set; }
        public string Nationality { get; set; }
        public int AppearancesOverall { get; set; }
        public int AppearancesHome { get; set; }
        public int AppearancesAway { get; set; }
        public int GoalsOverall { get; set; }
        public int GoalsHome { get; set; }
        public int GoalsAway { get; set; }
        public int AssistsOverall { get; set; }
        public int AssistsHome { get; set; }
        public int AssistsAway { get; set; }
        public int PenaltyGoals { get; set; }
        public int PenaltyMisses { get; set; }
        public int CleanSheetsOverall { get; set; }
        public int CleanSheetsHome { get; set; }
        public int CleanSheetsAway { get; set; }
        public int ConcededOverall { get; set; }
        public int ConcededHome { get; set; }
        public int ConcededAway { get; set; }
        public int YellowCardsOverall { get; set; }
        public int RedCardsOverall { get; set; }
        public double GoalsInvolvedPer90Overall { get; set; }
        public double AssistsPer90Overall { get; set; }
        public double GoalsPer90Overall { get; set; }
        public double GoalsPer90Home { get; set; }
        public double GoalsPer90Away { get; set; }
        public double MinPerGoalOverall { get; set; }
        public double ConcededPer90Overall { get; set; }
        public double MinPerConcededOverall { get; set; }
        public int MinPerMatch { get; set; }
        public double MinPerCardOverall { get; set; }
        public double MinPerAssistOverall { get; set; }
        public double CardsPer90Overall { get; set; }
        public int RankInLeagueTopAttackers { get; set; }
        public int RankInLeagueTopMidfielders { get; set; }
        public int RankInLeagueTopDefenders { get; set; }
        public int RankInClubTopScorer { get; set; }
        public double AverageRatingOverall { get; set; }
        public double AssistsPerGameOverall { get; set; }
        public double SmAssistsTotalOverall { get; set; }
        public double AssistsPer90PercentileOverall { get; set; }
        public double PassesPer90Overall { get; set; }
        public double PassesPerGameOverall { get; set; }
        public double PassesPer90PercentileOverall { get; set; }
        public double PassesTotalOverall { get; set; }
        public double PassesCompletedPerGameOverall { get; set; }
        public double PassesCompletedTotalOverall { get; set; }
        public double PassCompletionRatePercentileOverall { get; set; }
        public double PassesCompletedPer90Overall { get; set; }
        public double PassesCompletedPer90PercentileOverall { get; set; }
        public double ShortPassesPerGameOverall { get; set; }
        public double LongPassesPerGameOverall { get; set; }
        public double KeyPassesPerGameOverall { get; set; }
        public double KeyPassesTotalOverall { get; set; }
        public double ThroughPassesPerGameOverall { get; set; }
        public double CrossesPerGameOverall { get; set; }
        public double TacklesPer90Overall { get; set; }
        public double TacklesPerGameOverall { get; set; }
        public double TacklesTotalOverall { get; set; }
        public double TacklesSuccessfulPerGameOverall { get; set; }
        public double DispossessedPerGameOverall { get; set; }
        public double PossessionRegainedPerGameOverall { get; set; }
        public double PressuresPerGameOverall { get; set; }
        public double SavesPerGameOverall { get; set; }
        public double InterceptionsPerGameOverall { get; set; }
        public double DribblesSuccessfulPerGameOverall { get; set; }
        public double ShotsFacedPerGameOverall { get; set; }
        public double ShotsPerGoalScoredOverall { get; set; }
        public double ShotsPer90Overall { get; set; }
        public double ShotsOffTargetPerGameOverall { get; set; }
        public double DribblesPerGameOverall { get; set; }
        public double DistanceTravelledPerGameOverall { get; set; }
        public double ShotsOnTargetPerGameOverall { get; set; }
        public double XgPerGameOverall { get; set; }
        public double ChancesCreatedPerGameOverall { get; set; }
        public double AerialDuelsWonPerGameOverall { get; set; }
        public double AerialDuelsPerGameOverall { get; set; }
        public double PossessionRegainedPer90Overall { get; set; }
        public double PossessionRegainedTotalOverall { get; set; }
        public double PossessionRegainedPer90PercentileOverall { get; set; }
        public string AdditionalInfo { get; set; }
        public int ShotsTotalOverall { get; set; }
        public double ShotsPerGameOverall { get; set; }
        public double ShotsPer90PercentileOverall { get; set; }
        public int ShotsOnTargetTotalOverall { get; set; }
        public double ShotsOnTargetPer90Overall { get; set; }
        public double ShotsOnTargetPer90PercentileOverall { get; set; }
        public int ShotsOffTargetTotalOverall { get; set; }
        public double ShotsOffTargetPer90Overall { get; set; }
        public double ShotsOffTargetPer90PercentileOverall { get; set; }
        public int GamesSubbedOut { get; set; }
        public int GamesSubbedIn { get; set; }
        public int GamesStarted { get; set; }
        public double TacklesPer90PercentileOverall { get; set; }
        public double TacklesSuccessfulPer90Overall { get; set; }
        public double TacklesSuccessfulPer90PercentileOverall { get; set; }
        public int TacklesSuccessfulTotalOverall { get; set; }
        public int InterceptionsTotalOverall { get; set; }
        public double InterceptionsPer90Overall { get; set; }
        public double InterceptionsPer90PercentileOverall { get; set; }
        public int CrossesTotalOverall { get; set; }
        public double CrossCompletionRatePercentileOverall { get; set; }
        public double CrossesPer90Overall { get; set; }
        public double CrossesPer90PercentileOverall { get; set; }
        public int ThroughPassesTotalOverall { get; set; }
        public double ThroughPassesPer90Overall { get; set; }
        public double ThroughPassesPer90PercentileOverall { get; set; }
        public int LongPassesTotalOverall { get; set; }
        public double LongPassesPer90Overall { get; set; }
        public double LongPassesPer90PercentileOverall { get; set; }
        public int ShortPassesTotalOverall { get; set; }
        public double ShortPassesPer90Overall { get; set; }
        public double ShortPassesPer90PercentileOverall { get; set; }
        public double KeyPassesPer90Overall { get; set; }
        public double KeyPassesPer90PercentileOverall { get; set; }
        public int DribblesTotalOverall { get; set; }
        public double DribblesPer90Overall { get; set; }
        public double DribblesPer90PercentileOverall { get; set; }
        public int DribblesSuccessfulTotalOverall { get; set; }
        public double DribblesSuccessfulPer90Overall { get; set; }
        public double DribblesSuccessfulPercentageOverall { get; set; }
        public int ChancesCreatedTotalOverall { get; set; }
        public double ChancesCreatedPer90Overall { get; set; }
        public double ChancesCreatedPer90PercentileOverall { get; set; }
        public int SavesTotalOverall { get; set; }
        public double SavePercentagePercentileOverall { get; set; }
        public double SavesPer90Overall { get; set; }
        public double SavesPer90PercentileOverall { get; set; }
        public int ShotsFacedTotalOverall { get; set; }
        public double ShotsPerGoalConcededOverall { get; set; }
        public int SmGoalsConcededTotalOverall { get; set; }
        public double ConcededPer90PercentileOverall { get; set; }
        public int GoalsScoredTotalOverall { get; set; }
        public double ShotsFacedPer90Overall { get; set; }
        public double ShotsFacedPer90PercentileOverall { get; set; }
        public double XgFacedPer90Overall { get; set; }
        public double XgFacedPer90PercentileOverall { get; set; }
        public double XgFacedPerGameOverall { get; set; }
        public double XgFacedTotalOverall { get; set; }
        public double SavePercentageOverall { get; set; }
        public int PressuresTotalOverall { get; set; }
        public double PressuresPer90Overall { get; set; }
        public double PressuresPer90PercentileOverall { get; set; }
        public double XgTotalOverall { get; set; }
        public double MarketValue { get; set; }
        public double MarketValuePercentile { get; set; }
        public double PassCompletionRateOverall { get; set; }
        public double ShotAccuracyPercentageOverall { get; set; }
        public double ShotAccuracyPercentagePercentileOverall { get; set; }
        public int SmGoalsScoredTotalOverall { get; set; }
        public double DribbledPastPer90PercentileOverall { get; set; }
        public double DribbledPastPerGameOverall { get; set; }
        public double DribbledPastPer90Overall { get; set; }
        public int DribbledPastTotalOverall { get; set; }
        public double DribblesSuccessfulPer90PercentileOverall { get; set; }
        public double DribblesSuccessfulPercentagePercentileOverall { get; set; }
        public int PenScoredTotalOverall { get; set; }
        public int PenMissedTotalOverall { get; set; }
        public int InsideBoxSavesTotalOverall { get; set; }
        public double BlocksPerGameOverall { get; set; }
        public double BlocksPer90Overall { get; set; }
        public int BlocksTotalOverall { get; set; }
        public double BlocksPer90PercentileOverall { get; set; }
        public int RatingsTotalOverall { get; set; }
        public double ClearancesPerGameOverall { get; set; }
        public double ClearancesPer90Overall { get; set; }
        public int ClearancesTotalOverall { get; set; }
        public int PenCommittedTotalOverall { get; set; }
        public double PenSavePercentageOverall { get; set; }
        public double PenCommittedPer90Overall { get; set; }
        public double PenCommittedPer90PercentileOverall { get; set; }
        public double PenCommittedPerGameOverall { get; set; }
        public int PensSavedTotalOverall { get; set; }
        public int PensTakenTotalOverall { get; set; }
        public int HitWoodworkTotalOverall { get; set; }
        public double HitWoodworkPerGameOverall { get; set; }
        public double HitWoodworkPer90Overall { get; set; }
        public int PunchesTotalOverall { get; set; }
        public double PunchesPerGameOverall { get; set; }
        public double PunchesPer90Overall { get; set; }
        public double OffsidesPer90Overall { get; set; }
        public double OffsidesPerGameOverall { get; set; }
        public int OffsidesTotalOverall { get; set; }
        public int PenaltiesWonTotalOverall { get; set; }
        public double ShotConversionRateOverall { get; set; }
        public double ShotConversionRatePercentileOverall { get; set; }
        public double SmMinutesPlayedPer90PercentileOverall { get; set; }
        public int SmMinutesPlayedRecordedOverall { get; set; }
        public double MinutesPlayedPercentileOverall { get; set; }
        public double MatchesPlayedPercentileOverall { get; set; }
        public double MinPerGoalPercentileOverall { get; set; }
        public double MinPerConcededPercentileOverall { get; set; }
        public double XaTotalOverall { get; set; }
        public double XaPer90PercentileOverall { get; set; }
        public double XaPerGameOverall { get; set; }
        public double XaPer90Overall { get; set; }
        public double NpxgTotalOverall { get; set; }
        public double NpxgPer90PercentileOverall { get; set; }
        public double NpxgPerGameOverall { get; set; }
        public double NpxgPer90Overall { get; set; }
        public double FoulsDrawnPer90PercentileOverall { get; set; }
        public double FoulsDrawnTotalOverall { get; set; }
        public double FoulsDrawnPerGameOverall { get; set; }
        public double FoulsDrawnPer90Overall { get; set; }
        public double FoulsCommittedPer90Overall { get; set; }
        public double FoulsCommittedPerGameOverall { get; set; }
        public double FoulsCommittedPer90PercentileOverall { get; set; }
        public double FoulsCommittedTotalOverall { get; set; }
        public double XgPer90Overall { get; set; }
        public double XgPer90PercentileOverall { get; set; }
        public double AverageRatingPercentileOverall { get; set; }
        public double ClearancesPer90PercentileOverall { get; set; }
        public double HitWoodworkPer90PercentileOverall { get; set; }
        public double PunchesPer90PercentileOverall { get; set; }
        public double OffsidesPer90PercentileOverall { get; set; }
        public double AerialDuelsWonPer90PercentileOverall { get; set; }
        public double AerialDuelsTotalOverall { get; set; }
        public double AerialDuelsPer90Overall { get; set; }
        public double AerialDuelsPer90PercentileOverall { get; set; }
        public double AerialDuelsWonTotalOverall { get; set; }
        public double AerialDuelsWonPercentageOverall { get; set; }
        public double AerialDuelsWonPer90Overall { get; set; }
        public double DuelsPer90Overall { get; set; }
        public double DuelsPerGameOverall { get; set; }
        public double DuelsTotalOverall { get; set; }
        public double DuelsWonTotalOverall { get; set; }
        public double DuelsWonPer90PercentileOverall { get; set; }
        public double DuelsPer90PercentileOverall { get; set; }
        public double DuelsWonPer90Overall { get; set; }
        public double DuelsWonPerGameOverall { get; set; }
        public double DuelsWonPercentageOverall { get; set; }
        public double DispossessedTotalOverall { get; set; }
        public double DispossessedPer90Overall { get; set; }
        public double DispossessedPer90PercentileOverall { get; set; }
        public double ProgressivePassesTotalOverall { get; set; }
        public double CrossCompletionRateOverall { get; set; }
        public double DistanceTravelledTotalOverall { get; set; }
        public double DistanceTravelledPer90Overall { get; set; }
        public double DistanceTravelledPer90PercentileOverall { get; set; }
        public double AccurateCrossesTotalOverall { get; set; }
        public double AccurateCrossesPerGameOverall { get; set; }
        public double AccurateCrossesPer90Overall { get; set; }
        public double AccurateCrossesPer90PercentileOverall { get; set; }
        public double SmMatchesRecordedTotalOverall { get; set; }
        public double GamesStartedPercentileOverall { get; set; }
        public double GamesSubbedInPercentileOverall { get; set; }
        public double GamesSubbedOutPercentileOverall { get; set; }
        public int HattricksTotalOverall { get; set; }
        public int TwoGoalsInAGameTotalOverall { get; set; }
        public int ThreeGoalsInAGameTotalOverall { get; set; }
        public double TwoGoalsInAGamePercentageOverall { get; set; }
        public double ThreeGoalsInAGamePercentageOverall { get; set; }
        public double GoalsInvolvedPer90PercentileOverall { get; set; }
        public double GoalsPer90PercentileOverall { get; set; }
        public double GoalsPer90PercentileAway { get; set; }
        public double GoalsPer90PercentileHome { get; set; }
        public int ManOfTheMatchTotalOverall { get; set; }
        public double AnnualSalaryEur { get; set; }
        public double AnnualSalaryEurPercentile { get; set; }
        public double CleanSheetsPercentagePercentileOverall { get; set; }
        public double MinPerCardPercentileOverall { get; set; }
        public double CardsPer90PercentileOverall { get; set; }
        public double BookedOver05Overall { get; set; }
        public double BookedOver05PercentageOverall { get; set; }
        public double BookedOver05PercentagePercentileOverall { get; set; }
        public string ShirtNumber { get; set; }
        public double AnnualSalaryGbp { get; set; }
        public double AnnualSalaryUsd { get; set; }

        public clsPlayer(string fullName,
            int age,
            string birthday,
            string birthdayGMT,
            string league,
            string season,
            string position,
            string currentClub,
            int minutesPlayedOverall,
            int minutesPlayedHome,
            int minutesPlayedAway,
            string nationality,
            int appearancesOverall,
            int appearancesHome,
            int appearancesAway,
            int goalsOverall,
            int goalsHome,
            int goalsAway,
            int assistsOverall,
            int assistsHome,
            int assistsAway,
            int penaltyGoals,
            int penaltyMisses,
            int cleanSheetsOverall,
            int cleanSheetsHome,
            int cleanSheetsAway,
            int concededOverall,
            int concededHome,
            int concededAway,
            int yellowCardsOverall,
            int redCardsOverall,
            double goalsInvolvedPer90Overall,
            double assistsPer90Overall,
            double goalsPer90Overall,
            double goalsPer90Home,
            double goalsPer90Away,
            double minPerGoalOverall,
            double concededPer90Overall,
            double minPerConcededOverall,
            int minPerMatch,
            double minPerCardOverall,
            double minPerAssistOverall,
            double cardsPer90Overall,
            int rankInLeagueTopAttackers,
            int rankInLeagueTopMidfielders,
            int rankInLeagueTopDefenders,
            int rankInClubTopScorer,
            double averageRatingOverall,
            double assistsPerGameOverall,
            int smAssistsTotalOverall,
            double assistsPer90PercentileOverall,
            double passesPer90Overall,
            double passesPerGameOverall,
            double passesPer90PercentileOverall,
            int passesTotalOverall,
            int passesCompletedPerGameOverall,
            int passesCompletedTotalOverall,
            double passCompletionRatePercentileOverall,
            double passesCompletedPer90Overall,
            double passesCompletedPer90PercentileOverall,
            int shortPassesPerGameOverall,
            int longPassesPerGameOverall,
            int keyPassesPerGameOverall,
            int keyPassesTotalOverall,
            int throughPassesPerGameOverall,
            int crossesPerGameOverall,
            double tacklesPer90Overall,
            double tacklesPerGameOverall,
            int tacklesTotalOverall,
            double tacklesSuccessfulPerGameOverall,
            double dispossessedPerGameOverall,
            double possessionRegainedPerGameOverall,
            double pressuresPerGameOverall,
            double savesPerGameOverall,
            double interceptionsPerGameOverall,
            double dribblesSuccessfulPerGameOverall,
            double shotsFacedPerGameOverall,
            double shotsPerGoalScoredOverall,
            double shotsPer90Overall,
            double shotsOffTargetPerGameOverall,
            double dribblesPerGameOverall,
            double distanceTravelledPerGameOverall,
            double shotsOnTargetPerGameOverall,
            double xgPerGameOverall,
            double chancesCreatedPerGameOverall,
            double aerialDuelsWonPerGameOverall,
            double aerialDuelsPerGameOverall,
            double possessionRegainedPer90Overall,
            int possessionRegainedTotalOverall,
            double possessionRegainedPer90PercentileOverall,
            string additionalInfo,
            int shotsTotalOverall,
            double shotsPerGameOverall,
            double shotsPer90PercentileOverall,
            int shotsOnTargetTotalOverall,
            double shotsOnTargetPer90Overall,
            double shotsOnTargetPer90PercentileOverall,
            int shotsOffTargetTotalOverall,
            double shotsOffTargetPer90Overall,
            double shotsOffTargetPer90PercentileOverall,
            int gamesSubbedOut,
            int gamesSubbedIn,
            int gamesStarted,
            double tacklesPer90PercentileOverall,
            double tacklesSuccessfulPer90Overall,
            double tacklesSuccessfulPer90PercentileOverall,
            int tacklesSuccessfulTotalOverall,
            int interceptionsTotalOverall,
            double interceptionsPer90Overall,
            double interceptionsPer90PercentileOverall,
            int crossesTotalOverall,
            double crossCompletionRatePercentileOverall,
            double crossesPer90Overall,
            double crossesPer90PercentileOverall,
            int throughPassesTotalOverall,
            double throughPassesPer90Overall,
            double throughPassesPer90PercentileOverall,
            int longPassesTotalOverall,
            double longPassesPer90Overall,
            double longPassesPer90PercentileOverall,
            int shortPassesTotalOverall,
            double shortPassesPer90Overall,
            double shortPassesPer90PercentileOverall,
            double keyPassesPer90Overall,
            double keyPassesPer90PercentileOverall,
            int dribblesTotalOverall,
            double dribblesPer90Overall,
            double dribblesPer90PercentileOverall,
            int dribblesSuccessfulTotalOverall,
            double dribblesSuccessfulPer90Overall,
            double dribblesSuccessfulPercentageOverall,
            int chancesCreatedTotalOverall,
            double chancesCreatedPer90Overall,
            double chancesCreatedPer90PercentileOverall,
            int savesTotalOverall,
            double savePercentagePercentileOverall,
            double savesPer90Overall,
            double savesPer90PercentileOverall,
            int shotsFacedTotalOverall,
            double shotsPerGoalConcededOverall,
            int smGoalsConcededTotalOverall,
            double concededPer90PercentileOverall,
            double shotsFacedPer90Overall,
            double shotsFacedPer90PercentileOverall,
            double xgFacedPer90Overall,
            double xgFacedPer90PercentileOverall,
            double xgFacedPerGameOverall,
            double xgFacedTotalOverall,
            double savePercentageOverall,
            int pressuresTotalOverall,
            double pressuresPer90Overall,
            double pressuresPer90PercentileOverall,
            double xgTotalOverall,
            double marketValue,
            double marketValuePercentile,
            double passCompletionRateOverall,
            double shotAccuracyPercentageOverall,
            double shotAccuracyPercentagePercentileOverall,
            int smGoalsScoredTotalOverall,
            double dribbledPastPer90PercentileOverall,
            double dribbledPastPerGameOverall,
            double dribbledPastPer90Overall,
            int dribbledPastTotalOverall,
            double dribblesSuccessfulPer90PercentileOverall,
            double dribblesSuccessfulPercentagePercentileOverall,
            int penScoredTotalOverall,
            int penMissedTotalOverall,
            int insideBoxSavesTotalOverall,
            double blocksPerGameOverall,
            double blocksPer90Overall,
            int blocksTotalOverall,
            double blocksPer90PercentileOverall,
            int ratingsTotalOverall,
            double clearancesPerGameOverall,
            double clearancesPer90Overall,
            int clearancesTotalOverall,
            int penCommittedTotalOverall,
            double penSavePercentageOverall,
            double penCommittedPer90Overall,
            double penCommittedPer90PercentileOverall,
            double penCommittedPerGameOverall,
            int pensSavedTotalOverall,
            int pensTakenTotalOverall,
            int hitWoodworkTotalOverall,
            double hitWoodworkPerGameOverall,
            double hitWoodworkPer90Overall,
            int punchesTotalOverall,
            double punchesPerGameOverall,
            double punchesPer90Overall,
            double offsidesPer90Overall,
            double offsidesPerGameOverall,
            int offsidesTotalOverall,
            int penaltiesWonTotalOverall,
            double shotConversionRateOverall,
            double shotConversionRatePercentileOverall,
            double smMinutesPlayedPer90PercentileOverall,
            int smMinutesPlayedRecordedOverall,
            double minutesPlayedPercentileOverall,
            double matchesPlayedPercentileOverall,
            double minPerGoalPercentileOverall,
            double minPerConcededPercentileOverall,
            double xaTotalOverall,
            double xaPer90PercentileOverall,
            double xaPerGameOverall,
            double xaPer90Overall,
            double npxgTotalOverall,
            double npxgPer90PercentileOverall,
            double npxgPerGameOverall,
            double npxgPer90Overall,
            double foulsDrawnPer90PercentileOverall,
            int foulsDrawnTotalOverall,
            double foulsDrawnPerGameOverall,
            double foulsDrawnPer90Overall,
            double foulsCommittedPer90Overall,
            double foulsCommittedPerGameOverall,
            double foulsCommittedPer90PercentileOverall,
            int foulsCommittedTotalOverall,
            double xgPer90Overall,
            double xgPer90PercentileOverall,
            double averageRatingPercentileOverall,
            double clearancesPer90PercentileOverall,
            double hitWoodworkPer90PercentileOverall,
            double punchesPer90PercentileOverall,
            double offsidesPer90PercentileOverall,
            double aerialDuelsWonPer90PercentileOverall,
            int aerialDuelsTotalOverall,
            double aerialDuelsPer90Overall,
            double aerialDuelsPer90PercentileOverall,
            int aerialDuelsWonTotalOverall,
            double aerialDuelsWonPercentageOverall,
            double aerialDuelsWonPer90Overall,
            double duelsPer90Overall,
            double duelsPerGameOverall,
            int duelsTotalOverall,
            int duelsWonTotalOverall,
            double duelsWonPer90PercentileOverall,
            double duelsPer90PercentileOverall,
            double duelsWonPer90Overall,
            double duelsWonPerGameOverall,
            double duelsWonPercentageOverall,
            int dispossessedTotalOverall,
            double dispossessedPer90Overall,
            double dispossessedPer90PercentileOverall,
            int progressivePassesTotalOverall,
            double crossCompletionRateOverall,
            int distanceTravelledTotalOverall,
            double distanceTravelledPer90Overall,
            double distanceTravelledPer90PercentileOverall,
            int accurateCrossesTotalOverall,
            double accurateCrossesPerGameOverall,
            double accurateCrossesPer90Overall,
            double accurateCrossesPer90PercentileOverall,
            int smMatchesRecordedTotalOverall,
            double gamesStartedPercentileOverall,
            double gamesSubbedInPercentileOverall,
            double gamesSubbedOutPercentileOverall,
            int hattricksTotalOverall,
            int twoGoalsInAGameTotalOverall,
            int threeGoalsInAGameTotalOverall,
            double twoGoalsInAGamePercentageOverall,
            double threeGoalsInAGamePercentageOverall,
            double goalsInvolvedPer90PercentileOverall,
            double goalsPer90PercentileOverall,
            double goalsPer90PercentileAway,
            double goalsPer90PercentileHome,
            int manOfTheMatchTotalOverall,
            double annualSalaryEur,
            double annualSalaryEurPercentile,
            double cleanSheetsPercentagePercentileOverall,
            double minPerCardPercentileOverall,
            double cardsPer90PercentileOverall,
            int bookedOver05Overall,
            double bookedOver05PercentageOverall,
            double bookedOver05PercentagePercentileOverall,
            string shirtNumber,
            double annualSalaryGbp,
            double annualSalaryUsd)
        {
            this.FullName = fullName;
            this.Age = age;
            this.Birthday = birthday;
            this.BirthdayGMT = birthdayGMT;
            this.League = league;
            this.Season = season;
            this.Position = position;
            this.CurrentClub = currentClub;
            this.MinutesPlayedOverall = minutesPlayedOverall;
            this.MinutesPlayedHome = minutesPlayedHome;
            this.MinutesPlayedAway = minutesPlayedAway;
            this.Nationality = nationality;
            this.AppearancesOverall = appearancesOverall;
            this.AppearancesHome = appearancesHome;
            this.AppearancesAway = appearancesAway;
            this.GoalsOverall = goalsOverall;
            this.GoalsHome = goalsHome;
            this.GoalsAway = goalsAway;
            this.AssistsOverall = assistsOverall;
            this.AssistsHome = assistsHome;
            this.AssistsAway = assistsAway;
            this.PenaltyGoals = penaltyGoals;
            this.PenaltyMisses = penaltyMisses;
            this.CleanSheetsOverall = cleanSheetsOverall;
            this.CleanSheetsHome = cleanSheetsHome;
            this.CleanSheetsAway = cleanSheetsAway;
            this.ConcededOverall = concededOverall;
            this.ConcededHome = concededHome;
            this.ConcededAway = concededAway;
            this.YellowCardsOverall = yellowCardsOverall;
            this.RedCardsOverall = redCardsOverall;
            this.GoalsInvolvedPer90Overall = goalsInvolvedPer90Overall;
            this.AssistsPer90Overall = assistsPer90Overall;
            this.GoalsPer90Overall = goalsPer90Overall;
            this.GoalsPer90Home = goalsPer90Home;
            this.GoalsPer90Away = goalsPer90Away;
            this.MinPerGoalOverall = minPerGoalOverall;
            this.ConcededPer90Overall = concededPer90Overall;
            this.MinPerConcededOverall = minPerConcededOverall;
            this.MinPerMatch = minPerMatch;
            this.MinPerCardOverall = minPerCardOverall;
            this.MinPerAssistOverall = minPerAssistOverall;
            this.CardsPer90Overall = cardsPer90Overall;
            this.RankInLeagueTopAttackers = rankInLeagueTopAttackers;
            this.RankInLeagueTopMidfielders = rankInLeagueTopMidfielders;
            this.RankInLeagueTopDefenders = rankInLeagueTopDefenders;
            this.RankInClubTopScorer = rankInClubTopScorer;
            this.AverageRatingOverall = averageRatingOverall;
            this.AssistsPerGameOverall = assistsPerGameOverall;
            this.SmAssistsTotalOverall = smAssistsTotalOverall;
            this.AssistsPer90PercentileOverall = assistsPer90PercentileOverall;
            this.PassesPer90Overall = passesPer90Overall;
            this.PassesPerGameOverall = passesPerGameOverall;
            this.PassesPer90PercentileOverall = passesPer90PercentileOverall;
            this.PassesTotalOverall = passesTotalOverall;
            this.PassesCompletedPerGameOverall = passesCompletedPerGameOverall;
            this.PassesCompletedTotalOverall = passesCompletedTotalOverall;
            this.PassCompletionRatePercentileOverall = passCompletionRatePercentileOverall;
            this.PassesCompletedPer90Overall = passesCompletedPer90Overall;
            this.PassesCompletedPer90PercentileOverall = passesCompletedPer90PercentileOverall;
            this.ShortPassesPerGameOverall = shortPassesPerGameOverall;
            this.LongPassesPerGameOverall = longPassesPerGameOverall;
            this.KeyPassesPerGameOverall = keyPassesPerGameOverall;
            this.KeyPassesTotalOverall = keyPassesTotalOverall;
            this.ThroughPassesPerGameOverall = throughPassesPerGameOverall;
            this.CrossesPerGameOverall = crossesPerGameOverall;
            this.TacklesPer90Overall = tacklesPer90Overall;
            this.TacklesPerGameOverall = tacklesPerGameOverall;
            this.TacklesTotalOverall = tacklesTotalOverall;
            this.TacklesSuccessfulPerGameOverall = tacklesSuccessfulPerGameOverall;
            this.DispossessedPerGameOverall = dispossessedPerGameOverall;
            this.PossessionRegainedPerGameOverall = possessionRegainedPerGameOverall;
            this.PressuresPerGameOverall = pressuresPerGameOverall;
            this.SavesPerGameOverall = savesPerGameOverall;
            this.InterceptionsPerGameOverall = interceptionsPerGameOverall;
            this.DribblesSuccessfulPerGameOverall = dribblesSuccessfulPerGameOverall;
            this.ShotsFacedPerGameOverall = shotsFacedPerGameOverall;
            this.ShotsPerGoalScoredOverall = shotsPerGoalScoredOverall;
            this.ShotsPer90Overall = shotsPer90Overall;
            this.ShotsOffTargetPerGameOverall = shotsOffTargetPerGameOverall;
            this.DribblesPerGameOverall = dribblesPerGameOverall;
            this.DistanceTravelledPerGameOverall = distanceTravelledPerGameOverall;
            this.ShotsOnTargetPerGameOverall = shotsOnTargetPerGameOverall;
            this.XgPerGameOverall = xgPerGameOverall;
            this.ChancesCreatedPerGameOverall = chancesCreatedPerGameOverall;
            this.AerialDuelsWonPerGameOverall = aerialDuelsWonPerGameOverall;
            this.AerialDuelsPerGameOverall = aerialDuelsPerGameOverall;
            this.PossessionRegainedPer90Overall = possessionRegainedPer90Overall;
            this.PossessionRegainedTotalOverall = possessionRegainedTotalOverall;
            this.PossessionRegainedPer90PercentileOverall = possessionRegainedPer90PercentileOverall;
            this.AdditionalInfo = additionalInfo;
            this.ShotsTotalOverall = shotsTotalOverall;
            this.ShotsPerGameOverall = shotsPerGameOverall;
            this.ShotsPer90PercentileOverall = shotsPer90PercentileOverall;
            this.ShotsOnTargetTotalOverall = shotsOnTargetTotalOverall;
            this.ShotsOnTargetPer90Overall = shotsOnTargetPer90Overall;
            this.ShotsOnTargetPer90PercentileOverall = shotsOnTargetPer90PercentileOverall;
            this.ShotsOffTargetTotalOverall = shotsOffTargetTotalOverall;
            this.ShotsOffTargetPer90Overall = shotsOffTargetPer90Overall;
            this.ShotsOffTargetPer90PercentileOverall = shotsOffTargetPer90PercentileOverall;
            this.GamesSubbedOut = gamesSubbedOut;
            this.GamesSubbedIn = gamesSubbedIn;
            this.GamesStarted = gamesStarted;
            this.TacklesPer90PercentileOverall = tacklesPer90PercentileOverall;
            this.TacklesSuccessfulPer90Overall = tacklesSuccessfulPer90Overall;
            this.TacklesSuccessfulPer90PercentileOverall = tacklesSuccessfulPer90PercentileOverall;
            this.TacklesSuccessfulTotalOverall = tacklesSuccessfulTotalOverall;
            this.InterceptionsTotalOverall = interceptionsTotalOverall;
            this.InterceptionsPer90Overall = interceptionsPer90Overall;
            this.InterceptionsPer90PercentileOverall = interceptionsPer90PercentileOverall;
            this.CrossesTotalOverall = crossesTotalOverall;
            this.CrossCompletionRatePercentileOverall = crossCompletionRatePercentileOverall;
            this.CrossesPer90Overall = crossesPer90Overall;
            this.CrossesPer90PercentileOverall = crossesPer90PercentileOverall;
            this.ThroughPassesTotalOverall = throughPassesTotalOverall;
            this.ThroughPassesPer90Overall = throughPassesPer90Overall;
            this.ThroughPassesPer90PercentileOverall = throughPassesPer90PercentileOverall;
            this.LongPassesTotalOverall = longPassesTotalOverall;
            this.LongPassesPer90Overall = longPassesPer90Overall;
            this.LongPassesPer90PercentileOverall = longPassesPer90PercentileOverall;
            this.ShortPassesTotalOverall = shortPassesTotalOverall;
            this.ShortPassesPer90Overall = shortPassesPer90Overall;
            this.ShortPassesPer90PercentileOverall = shortPassesPer90PercentileOverall;
            this.KeyPassesPer90Overall = keyPassesPer90Overall;
            this.KeyPassesPer90PercentileOverall = keyPassesPer90PercentileOverall;
            this.DribblesTotalOverall = dribblesTotalOverall;
            this.DribblesPer90Overall = dribblesPer90Overall;
            this.DribblesPer90PercentileOverall = dribblesPer90PercentileOverall;
            this.DribblesSuccessfulTotalOverall = dribblesSuccessfulTotalOverall;
            this.DribblesSuccessfulPer90Overall = dribblesSuccessfulPer90Overall;
            this.DribblesSuccessfulPercentageOverall = dribblesSuccessfulPercentageOverall;
            this.ChancesCreatedTotalOverall = chancesCreatedTotalOverall;
            this.ChancesCreatedPer90Overall = chancesCreatedPer90Overall;
            this.ChancesCreatedPer90PercentileOverall = chancesCreatedPer90PercentileOverall;
            this.SavesTotalOverall = savesTotalOverall;
            this.SavePercentagePercentileOverall = savePercentagePercentileOverall;
            this.SavesPer90Overall = savesPer90Overall;
            this.SavesPer90PercentileOverall = savesPer90PercentileOverall;
            this.ShotsFacedTotalOverall = shotsFacedTotalOverall;
            this.ShotsPerGoalConcededOverall = shotsPerGoalConcededOverall;
            this.SmGoalsConcededTotalOverall = smGoalsConcededTotalOverall;
            this.ConcededPer90PercentileOverall = concededPer90PercentileOverall;
            this.ShotsFacedPer90Overall = shotsFacedPer90Overall;
            this.ShotsFacedPer90PercentileOverall = shotsFacedPer90PercentileOverall;
            this.XgFacedPer90Overall = xgFacedPer90Overall;
            this.XgFacedPer90PercentileOverall = xgFacedPer90PercentileOverall;
            this.XgFacedPerGameOverall = xgFacedPerGameOverall;
            this.XgFacedTotalOverall = xgFacedTotalOverall;
            this.SavePercentageOverall = savePercentageOverall;
            this.PressuresTotalOverall = pressuresTotalOverall;
            this.PressuresPer90Overall = pressuresPer90Overall;
            this.PressuresPer90PercentileOverall = pressuresPer90PercentileOverall;
            this.XgTotalOverall = xgTotalOverall;
            this.MarketValue = marketValue;
            this.MarketValuePercentile = marketValuePercentile;
            this.PassCompletionRateOverall = passCompletionRateOverall;
            this.ShotAccuracyPercentageOverall = shotAccuracyPercentageOverall;
            this.ShotAccuracyPercentagePercentileOverall = shotAccuracyPercentagePercentileOverall;
            this.SmGoalsScoredTotalOverall = smGoalsScoredTotalOverall;
            this.DribbledPastPer90PercentileOverall = dribbledPastPer90PercentileOverall;
            this.DribbledPastPerGameOverall = dribbledPastPerGameOverall;
            this.DribbledPastPer90Overall = dribbledPastPer90Overall;
            this.DribbledPastTotalOverall = dribbledPastTotalOverall;
            this.DribblesSuccessfulPer90PercentileOverall = dribblesSuccessfulPer90PercentileOverall;
            this.DribblesSuccessfulPercentagePercentileOverall = dribblesSuccessfulPercentagePercentileOverall;
            this.PenScoredTotalOverall = penScoredTotalOverall;
            this.PenMissedTotalOverall = penMissedTotalOverall;
            this.InsideBoxSavesTotalOverall = insideBoxSavesTotalOverall;
            this.BlocksPerGameOverall = blocksPerGameOverall;
            this.BlocksPer90Overall = blocksPer90Overall;
            this.BlocksTotalOverall = blocksTotalOverall;
            this.BlocksPer90PercentileOverall = blocksPer90PercentileOverall;
            this.RatingsTotalOverall = ratingsTotalOverall;
            this.ClearancesPerGameOverall = clearancesPerGameOverall;
            this.ClearancesPer90Overall = clearancesPer90Overall;
            this.ClearancesTotalOverall = clearancesTotalOverall;
            this.PenCommittedTotalOverall = penCommittedTotalOverall;
            this.PenSavePercentageOverall = penSavePercentageOverall;
            this.PenCommittedPer90Overall = penCommittedPer90Overall;
            this.PenCommittedPer90PercentileOverall = penCommittedPer90PercentileOverall;
            this.PenCommittedPerGameOverall = penCommittedPerGameOverall;
            this.PensSavedTotalOverall = pensSavedTotalOverall;
            this.PensTakenTotalOverall = pensTakenTotalOverall;
            this.HitWoodworkTotalOverall = hitWoodworkTotalOverall;
            this.HitWoodworkPerGameOverall = hitWoodworkPerGameOverall;
            this.HitWoodworkPer90Overall = hitWoodworkPer90Overall;
            this.PunchesTotalOverall = punchesTotalOverall;
            this.PunchesPerGameOverall = punchesPerGameOverall;
            this.PunchesPer90Overall = punchesPer90Overall;
            this.OffsidesPer90Overall = offsidesPer90Overall;
            this.OffsidesPerGameOverall = offsidesPerGameOverall;
            this.OffsidesTotalOverall = offsidesTotalOverall;
            this.PenaltiesWonTotalOverall = penaltiesWonTotalOverall;
            this.ShotConversionRateOverall = shotConversionRateOverall;
            this.ShotConversionRatePercentileOverall = shotConversionRatePercentileOverall;
            this.SmMinutesPlayedPer90PercentileOverall = smMinutesPlayedPer90PercentileOverall;
            this.SmMinutesPlayedRecordedOverall = smMinutesPlayedRecordedOverall;
            this.MinutesPlayedPercentileOverall = minutesPlayedPercentileOverall;
            this.MatchesPlayedPercentileOverall = matchesPlayedPercentileOverall;
            this.MinPerGoalPercentileOverall = minPerGoalPercentileOverall;
            this.MinPerConcededPercentileOverall = minPerConcededPercentileOverall;
            this.XaTotalOverall = xaTotalOverall;
            this.XaPer90PercentileOverall = xaPer90PercentileOverall;
            this.XaPerGameOverall = xaPerGameOverall;
            this.XaPer90Overall = xaPer90Overall;
            this.NpxgTotalOverall = npxgTotalOverall;
            this.NpxgPer90PercentileOverall = npxgPer90PercentileOverall;
            this.NpxgPerGameOverall = npxgPerGameOverall;
            this.NpxgPer90Overall = npxgPer90Overall;
            this.FoulsDrawnPer90PercentileOverall = foulsDrawnPer90PercentileOverall;
            this.FoulsDrawnTotalOverall = foulsDrawnTotalOverall;
            this.FoulsDrawnPerGameOverall = foulsDrawnPerGameOverall;
            this.FoulsDrawnPer90Overall = foulsDrawnPer90Overall;
            this.FoulsCommittedPer90Overall = foulsCommittedPer90Overall;
            this.FoulsCommittedPerGameOverall = foulsCommittedPerGameOverall;
            this.FoulsCommittedPer90PercentileOverall = foulsCommittedPer90PercentileOverall;
            this.FoulsCommittedTotalOverall = foulsCommittedTotalOverall;
            this.XgPer90Overall = xgPer90Overall;
            this.XgPer90PercentileOverall = xgPer90PercentileOverall;
            this.AverageRatingPercentileOverall = averageRatingPercentileOverall;
            this.ClearancesPer90PercentileOverall = clearancesPer90PercentileOverall;
            this.HitWoodworkPer90PercentileOverall = hitWoodworkPer90PercentileOverall;
            this.PunchesPer90PercentileOverall = punchesPer90PercentileOverall;
            this.OffsidesPer90PercentileOverall = offsidesPer90PercentileOverall;
            this.AerialDuelsWonPer90PercentileOverall = aerialDuelsWonPer90PercentileOverall;
            this.AerialDuelsTotalOverall = aerialDuelsTotalOverall;
            this.AerialDuelsPer90Overall = aerialDuelsPer90Overall;
            this.AerialDuelsPer90PercentileOverall = aerialDuelsPer90PercentileOverall;
            this.AerialDuelsWonTotalOverall = aerialDuelsWonTotalOverall;
            this.AerialDuelsWonPercentageOverall = aerialDuelsWonPercentageOverall;
            this.AerialDuelsWonPer90Overall = aerialDuelsWonPer90Overall;
            this.DuelsPer90Overall = duelsPer90Overall;
            this.DuelsPerGameOverall = duelsPerGameOverall;
            this.DuelsTotalOverall = duelsTotalOverall;
            this.DuelsWonTotalOverall = duelsWonTotalOverall;
            this.DuelsWonPer90PercentileOverall = duelsWonPer90PercentileOverall;
            this.DuelsPer90PercentileOverall = duelsPer90PercentileOverall;
            this.DuelsWonPer90Overall = duelsWonPer90Overall;
            this.DuelsWonPerGameOverall = duelsWonPerGameOverall;
            this.DuelsWonPercentageOverall = duelsWonPercentageOverall;
            this.DispossessedTotalOverall = dispossessedTotalOverall;
            this.DispossessedPer90Overall = dispossessedPer90Overall;
            this.DispossessedPer90PercentileOverall = dispossessedPer90PercentileOverall;
            this.ProgressivePassesTotalOverall = progressivePassesTotalOverall;
            this.CrossCompletionRateOverall = crossCompletionRateOverall;
            this.DistanceTravelledTotalOverall = distanceTravelledTotalOverall;
            this.DistanceTravelledPer90Overall = distanceTravelledPer90Overall;
            this.DistanceTravelledPer90PercentileOverall = distanceTravelledPer90PercentileOverall;
            this.AccurateCrossesTotalOverall = accurateCrossesTotalOverall;
            this.AccurateCrossesPerGameOverall = accurateCrossesPerGameOverall;
            this.AccurateCrossesPer90Overall = accurateCrossesPer90Overall;
            this.AccurateCrossesPer90PercentileOverall = accurateCrossesPer90PercentileOverall;
            this.SmMatchesRecordedTotalOverall = smMatchesRecordedTotalOverall;
            this.GamesStartedPercentileOverall = gamesStartedPercentileOverall;
            this.GamesSubbedInPercentileOverall = gamesSubbedInPercentileOverall;
            this.GamesSubbedOutPercentileOverall = gamesSubbedOutPercentileOverall;
            this.HattricksTotalOverall = hattricksTotalOverall;
            this.TwoGoalsInAGameTotalOverall = twoGoalsInAGameTotalOverall;
            this.ThreeGoalsInAGameTotalOverall = threeGoalsInAGameTotalOverall;
            this.TwoGoalsInAGamePercentageOverall = twoGoalsInAGamePercentageOverall;
            this.ThreeGoalsInAGamePercentageOverall = threeGoalsInAGamePercentageOverall;
            this.GoalsInvolvedPer90PercentileOverall = goalsInvolvedPer90PercentileOverall;
            this.GoalsPer90PercentileOverall = goalsPer90PercentileOverall;
            this.GoalsPer90PercentileAway = goalsPer90PercentileAway;
            this.GoalsPer90PercentileHome = goalsPer90PercentileHome;
            this.ManOfTheMatchTotalOverall = manOfTheMatchTotalOverall;
            this.AnnualSalaryEur = annualSalaryEur;
            this.AnnualSalaryEurPercentile = annualSalaryEurPercentile;
            this.CleanSheetsPercentagePercentileOverall = cleanSheetsPercentagePercentileOverall;
            this.MinPerCardPercentileOverall = minPerCardPercentileOverall;
            this.CardsPer90PercentileOverall = cardsPer90PercentileOverall;
            this.BookedOver05Overall = bookedOver05Overall;
            this.BookedOver05PercentageOverall = bookedOver05PercentageOverall;
            this.BookedOver05PercentagePercentileOverall = bookedOver05PercentagePercentileOverall;
            this.ShirtNumber = shirtNumber;
            this.AnnualSalaryGbp = annualSalaryGbp;
            this.AnnualSalaryUsd = annualSalaryUsd;
        }
    }
}