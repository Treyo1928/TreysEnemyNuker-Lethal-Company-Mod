using HarmonyLib;

namespace TreysEnemyNuker
{
	[HarmonyPatch(typeof(RoundManager), "LoadNewLevel")]
	public static class EnemyManagerPatch
	{
		public static void Postfix(RoundManager __instance, int randomSeed, SelectableLevel newLevel)
		{
			var outsideEnemies = __instance.currentLevel.OutsideEnemies;
			var Enemies = __instance.currentLevel.Enemies;
			var daytimeEnemies = __instance.currentLevel.DaytimeEnemies;
			if (outsideEnemies != null)
			{
				if (Plugin.RemoveMouthDog.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing MouthDogs");
					outsideEnemies.RemoveAll(enemy => enemy.enemyType.enemyName == "MouthDog");
				}
				if (Plugin.RemoveForestGiant.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing ForestGiants");
					outsideEnemies.RemoveAll(enemy => enemy.enemyType.enemyName == "ForestGiant");
				}
				if (Plugin.RemoveEarthLeviathan.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing EarthLeviathans");
					outsideEnemies.RemoveAll(enemy => enemy.enemyType.enemyName == "Earth Leviathan");
				}
				if (Plugin.RemoveBaboonHawk.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing BaboonHawks");
					outsideEnemies.RemoveAll(enemy => enemy.enemyType.enemyName == "Baboon hawk");
				}
			}
			if (Enemies != null)
			{
				if (Plugin.RemoveCentipede.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing Centipedes");
					Enemies.RemoveAll(enemy => enemy.enemyType.enemyName == "Centipede");
				}
				if (Plugin.RemoveBunkerSpider.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing BunkerSpiders");
					Enemies.RemoveAll(enemy => enemy.enemyType.enemyName == "Bunker Spider");
				}
				if (Plugin.RemoveHoardingBug.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing HoardingBugs");
					Enemies.RemoveAll(enemy => enemy.enemyType.enemyName == "Hoarding bug");
				}
				if (Plugin.RemoveFlowerMan.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing FlowerMen");
					Enemies.RemoveAll(enemy => enemy.enemyType.enemyName == "Flowerman");
				}
				if (Plugin.RemoveCrawler.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing Crawlers");
					Enemies.RemoveAll(enemy => enemy.enemyType.enemyName == "Crawler");
				}
				if (Plugin.RemoveBlob.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing Blobs");
					Enemies.RemoveAll(enemy => enemy.enemyType.enemyName == "Blob");
				}
				if (Plugin.RemoveSpring.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing Springs");
					Enemies.RemoveAll(enemy => enemy.enemyType.enemyName == "Spring");
				}
				if (Plugin.RemovePuffer.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing Puffers");
					Enemies.RemoveAll(enemy => enemy.enemyType.enemyName == "Puffer");
				}
				if (Plugin.RemoveNutcracker.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing Nutcrackers");
					Enemies.RemoveAll(enemy => enemy.enemyType.enemyName == "Nutcracker");
				}
			}
			if (daytimeEnemies != null)
			{
				if (Plugin.RemoveManticoil.Value)
				{
					Plugin.PluginLogger.LogInfo("Tried removing Manticoils");
					daytimeEnemies.RemoveAll(enemy => enemy.enemyType.enemyName == "Manticoil");
				}
			}
		}
	}
}
