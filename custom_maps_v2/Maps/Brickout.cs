using MelonLoader;
using Harmony;

using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;

using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;

using Assets.Scripts.Unity.UI_New.Main;

using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;

using Assets.Scripts.Unity;




using Assets.Scripts.Simulation.Towers;


using Assets.Scripts.Utils;


//using Il2CppSystem.Collections;


using Assets.Scripts.Unity.UI_New.Popups;
using System.Reflection;
using Assets.Scripts.Models;
using System.Collections.Generic;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Models.GenericBehaviors;
using System;
using System.Linq;
using Assets.Scripts.Models.ServerEvents;
using Assets.Scripts.Data.Cosmetics.Pets;
using Assets.Main.Scenes;
using UnhollowerBaseLib;

using Assets.Scripts.Models.Rounds;
using Assets.Scripts.Models.Store;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Map;
using UnityEngine;
using System.IO;
using UnhollowerRuntimeLib;
using Assets.Scripts.Models.Map.Spawners;

namespace custommaps.Maps
{
	class BrickoutData
	{

		public static Il2CppReferenceArray<PointInfo> track1()
		{
			return new System.Collections.Generic.List<PointInfo>
			{
				new PointInfo
				{
					bloonScale = 1f,
					bloonsInvulnerable = false,
					distance = 1f,
					id = (BrickoutData.r.NextDouble().ToString() ?? ""),
					moabScale = 1f,
					moabsInvulnerable = false,
					rotation = 0f,
					point = new Assets.Scripts.Simulation.SMath.Vector3(-57.22223f, -114.787f, 0f)
				},
				new PointInfo
				{
					bloonScale = 1f,
					bloonsInvulnerable = false,
					distance = 1f,
					id = (BrickoutData.r.NextDouble().ToString() ?? ""),
					moabScale = 1f,
					moabsInvulnerable = false,
					rotation = 0f,
					point = new Assets.Scripts.Simulation.SMath.Vector3(-58.33334f, -57.07408f, 0f)
				},
				new PointInfo
				{
					bloonScale = 1f,
					bloonsInvulnerable = false,
					distance = 1f,
					id = (BrickoutData.r.NextDouble().ToString() ?? ""),
					moabScale = 1f,
					moabsInvulnerable = false,
					rotation = 0f,
					point = new Assets.Scripts.Simulation.SMath.Vector3(-115.1852f, -55.15732f, 0f)
				},
				new PointInfo
				{
					bloonScale = 1f,
					bloonsInvulnerable = false,
					distance = 1f,
					id = (BrickoutData.r.NextDouble().ToString() ?? ""),
					moabScale = 1f,
					moabsInvulnerable = false,
					rotation = 0f,
					point = new Assets.Scripts.Simulation.SMath.Vector3(-113.7037f, 87.95366f, 0f)
				},
				new PointInfo
				{
					bloonScale = 1f,
					bloonsInvulnerable = false,
					distance = 1f,
					id = (BrickoutData.r.NextDouble().ToString() ?? ""),
					moabScale = 1f,
					moabsInvulnerable = false,
					rotation = 0f,
					point = new Assets.Scripts.Simulation.SMath.Vector3(-33.51852f, 89.65746f, 0f)
				},
				new PointInfo
				{
					bloonScale = 1f,
					bloonsInvulnerable = false,
					distance = 1f,
					id = (BrickoutData.r.NextDouble().ToString() ?? ""),
					moabScale = 1f,
					moabsInvulnerable = false,
					rotation = 0f,
					point = new Assets.Scripts.Simulation.SMath.Vector3(-32.22223f, -12.56479f, 0f)
				},
				new PointInfo
				{
					bloonScale = 1f,
					bloonsInvulnerable = false,
					distance = 1f,
					id = (BrickoutData.r.NextDouble().ToString() ?? ""),
					moabScale = 1f,
					moabsInvulnerable = false,
					rotation = 0f,
					point = new Assets.Scripts.Simulation.SMath.Vector3(122.963f, -15.12028f, 0f)
				},
				new PointInfo
				{
					bloonScale = 1f,
					bloonsInvulnerable = false,
					distance = 1f,
					id = (BrickoutData.r.NextDouble().ToString() ?? ""),
					moabScale = 1f,
					moabsInvulnerable = false,
					rotation = 0f,
					point = new Assets.Scripts.Simulation.SMath.Vector3(123.5185f, -80.71296f, 0f)
				},
				new PointInfo
				{
					bloonScale = 1f,
					bloonsInvulnerable = false,
					distance = 1f,
					id = (BrickoutData.r.NextDouble().ToString() ?? ""),
					moabScale = 1f,
					moabsInvulnerable = false,
					rotation = 0f,
					point = new Assets.Scripts.Simulation.SMath.Vector3(64.62964f, -80.07408f, 0f)
				},
				new PointInfo
				{
					bloonScale = 1f,
					bloonsInvulnerable = false,
					distance = 1f,
					id = (BrickoutData.r.NextDouble().ToString() ?? ""),
					moabScale = 1f,
					moabsInvulnerable = false,
					rotation = 0f,
					point = new Assets.Scripts.Simulation.SMath.Vector3(66.11111f, 90.50929f, 0f)
				},
				new PointInfo
				{
					bloonScale = 1f,
					bloonsInvulnerable = false,
					distance = 1f,
					id = (BrickoutData.r.NextDouble().ToString() ?? ""),
					moabScale = 1f,
					moabsInvulnerable = false,
					rotation = 0f,
					point = new Assets.Scripts.Simulation.SMath.Vector3(150.3704f, 86.88887f, 0f)
				}
			}.ToArray();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00017A40 File Offset: 0x00015C40
		public static Il2CppReferenceArray<AreaModel> areas()
		{
			List<AreaModel> newareas = new List<AreaModel>();

			var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, -114.787f));
			area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.5926f, -114.787f));
			area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, 115f));
			area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-147.7778f, 115f));
			newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0),Main.Empty(), 10, (AreaType)2));
			var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.92593f, -55.79634f));
			area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.44445f, -68.14817f));
			area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-10.92593f, -70.4907f));
			area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-9.444444f, -79.00929f));
			area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(3.518522f, -83.90733f));
			area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.40741f, -82.41662f));
			area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.07408f, -70.91662f));
			area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.85185f, -56.00929f));
			area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-15.37037f, -56.22211f));
			newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1),Main.Empty(), 10, (AreaType)1));
			var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.666671f, -11.28704f));
			area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.37036f, -11.28704f));
			area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.51852f, 2.555493f));
			area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.33334f, 90.72225f));
			area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, 91.14817f));
			area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.4074f, 115f));
			area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.7037f, 115f));
			area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-148.3333f, 92f));
			area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.666671f, 91.14817f));
			area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.296294f, -10.64817f));
			newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
			var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.00002f, -14.05549f));
			area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, -14.05549f));
			area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.7778f, 0f));
			area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, 14.69451f));
			area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.77779f, 14.69451f));
			area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(69.25928f, 0.6388733f));
			area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(69.62963f, -13.84254f));
			newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
			var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.5926f, -42.37958f));
			area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.5926f, -55.37028f));
			area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.5926f, -56.00929f));
			area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.03704f, 66.87042f));
			area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.11111f, 66.87042f));
			area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.55556f, -26.40732f));
			area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.77778f, -27.25929f));
			area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.77778f, -55.58338f));
			newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
			var area5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.22223f, -114.787f));
			area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.85186f, -107.5462f));
			area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.62963f, -92.42591f));
			area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.7778f, -92.21296f));
			area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, -114.787f));
			area5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.22223f, -114.787f));
			newareas.Add(new AreaModel("lol5", new Assets.Scripts.Simulation.SMath.Polygon(area5),Main.Empty(), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
			var area6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.59261f, -114.787f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.33334f, -68.14817f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-123.7037f, -67.29633f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-124.6296f, 92f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.81482f, 94.98154f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.25926f, 2.981549f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.77778f, 2.555493f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.14816f, 91.36112f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.5185f, 92.42591f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.7037f, 71.76859f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.5926f, 71.55549f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.62965f, 0.4259155f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(133.3333f, 0.851831f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(133.3333f, -92.21296f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.62963f, -90.93521f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.96297f, -26.62028f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-41.85185f, -26.40732f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.44445f, 71.34254f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.3704f, 71.12971f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.3704f, -38.33338f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.51852f, -38.12042f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-43.70371f, -114.787f));
			area6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-67.40742f, -114.787f));
			newareas.Add(new AreaModel("lol6", new Assets.Scripts.Simulation.SMath.Polygon(area6),Main.Empty(), 10, (AreaType)0));
			var area7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.33334f, -20.87042f));
			area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.88889f, -68.36112f));
			area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.1482f, -67.72225f));
			area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.7037f, -20.44437f));
			area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(73.88889f, -21.2962f));
			area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.77779f, -26.62028f));
			area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.96297f, -63.25f));
			area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.4445f, -63.03704f));
			area7.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.2593f, -26.83338f));
			newareas.Add(new AreaModel("lol7", new Assets.Scripts.Simulation.SMath.Polygon(area7),Main.Empty(), 10, (AreaType)0));
			var area8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.51852f, 2.555493f));
			area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.81483f, -90.50929f));
			area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(132.4074f, -91.57408f));
			area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(133.5185f, -5.962958f));
			area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.1482f, -20.65746f));
			area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(74.07407f, -21.50929f));
			area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(74.25927f, -67.72225f));
			area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.5185f, -67.50916f));
			area8.Add(new Assets.Scripts.Simulation.SMath.Vector2(113.7037f, -21.50929f));
			newareas.Add(new AreaModel("lol8", new Assets.Scripts.Simulation.SMath.Polygon(area8),Main.Empty(), 10, (AreaType)0));
			var area9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.77779f, -26.40732f));
			area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.77779f, -63.03704f));
			area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.2593f, -63.03704f));
			area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(109.6296f, -27.25929f));
			area9.Add(new Assets.Scripts.Simulation.SMath.Vector2(77.5926f, -26.62028f));
			newareas.Add(new AreaModel("lol9", new Assets.Scripts.Simulation.SMath.Polygon(area9),Main.Empty(), 10, (AreaType)2));




			return newareas.ToArray();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00018A78 File Offset: 0x00016C78
		public static PathSpawnerModel spawner()
		{
			return new PathSpawnerModel("", new SplitterModel("", new string[]
			{
				"Path1"
			}), new SplitterModel("", new string[]
			{
				"Path1"
			}));
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00018ACC File Offset: 0x00016CCC
		public static PathModel[] pathmodel()
		{
			return new PathModel[]
			{
				new PathModel("Path1", BrickoutData.track1(), true, false, default(Assets.Scripts.Simulation.SMath.Vector3), default(Assets.Scripts.Simulation.SMath.Vector3), null, null)
			};
		}

		// Token: 0x04000012 RID: 18
		public static System.Random r = new System.Random();
	}
}