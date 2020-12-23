using MelonLoader;
using Harmony;
using NKHook6.Api;
using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;
using NKHook6;
using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;
using NKHook6.Api.Extensions;
using Assets.Scripts.Unity.UI_New.Main;
using NKHook6.Api.Events;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;

using Assets.Scripts.Unity;



using static NKHook6.Api.Events._Towers.TowerEvents;
using Assets.Scripts.Simulation.Towers;

using static NKHook6.Api.Events._Weapons.WeaponEvents;
using Assets.Scripts.Utils;

using static NKHook6.Api.Events._TimeManager.TimeManagerEvents;
//using Il2CppSystem.Collections;
using NKHook6.Api.Events._Bloons;
using NKHook6.Api.Events._Weapons;
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

namespace custom_maps
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
			System.Collections.Generic.List<AreaModel> list = new System.Collections.Generic.List<AreaModel>();
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-16.66667f, -57.5f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.22223f, -57.18049f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.88888f, -65.48598f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(25.27778f, -74.75f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.33334f, -79.86098f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(22.22223f, -85.29162f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(16.38889f, -86.5695f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(13.33333f, -85.61112f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(9.444451f, -87.20824f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(3.333342f, -85.93049f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-3.88889f, -82.73612f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-8.333338f, -82.41662f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-11.38889f, -77.625f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.77778f, -70.91662f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.72223f, -69f));
			list2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-16.66667f, -57.5f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list2), 2f, AreaType.water, 0f, null, null, null, false, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.99999f, -114.6805f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.11111f, -71.23612f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-126.6667f, -70.27775f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-127.7778f, 96.15275f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.44444f, 99.02775f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.16666f, 2.236127f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(52.5f, 1.597253f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.16668f, 96.79176f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.8889f, 96.47225f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.8889f, 71.55549f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.16667f, 71.55549f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.33334f, 1.277887f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(135.8333f, -6.70838f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(135.2778f, -92f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(54.44444f, -91.68063f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.05556f, -27.79162f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.44445f, -26.19437f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-46.38889f, 70.59725f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.3889f, 70.59725f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.8333f, -38.97225f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.27778f, -44.40274f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.27778f, -114.6805f));
			list3.Add(new Assets.Scripts.Simulation.SMath.Vector2(-68.33334f, -114.3611f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list3), 2f, AreaType.track, 0f, null, null, null, false, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list4.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.44444f, -64.20838f));
			list4.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.61111f, -28.11113f));
			list4.Add(new Assets.Scripts.Simulation.SMath.Vector2(110f, -28.75f));
			list4.Add(new Assets.Scripts.Simulation.SMath.Vector2(110f, -64.84725f));
			list4.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.16667f, -64.20838f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list4), 2f, AreaType.land, 0f, null, null, null, false, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list5 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.4444f, 92f));
			list5.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.666671f, 92.63902f));
			list5.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.944441f, -11.5f));
			list5.Add(new Assets.Scripts.Simulation.SMath.Vector2(15.27777f, -12.13887f));
			list5.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.88888f, 1.277887f));
			list5.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.61111f, 91.68063f));
			list5.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.4444f, 91.68063f));
			list5.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.4444f, 114.0418f));
			list5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150.2778f, 114.6805f));
			list5.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.7222f, 92.3195f));
			list5.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.111114f, 92.3195f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list5), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list6 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150.2778f, -114.6805f));
			list6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150.5556f, 91.68063f));
			list6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-126.1111f, 91.36112f));
			list6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-125.8333f, -68.68049f));
			list6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.99999f, -70.27775f));
			list6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-69.44445f, -114.6805f));
			list6.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150f, -114.6805f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list6), 2f, AreaType.land, 0f, null, null, null, false, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list7 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-94.16667f, -40.25f));
			list7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-100.5555f, -40.25f));
			list7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-101.1111f, 70.91676f));
			list7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.83334f, 69.95838f));
			list7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.44445f, -25.875f));
			list7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-70.55555f, -25.875f));
			list7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.38889f, 68.36112f));
			list7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.88889f, 68.68049f));
			list7.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.61111f, -39.93049f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list7), 2f, AreaType.land, 0f, null, null, null, false, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list8 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.38889f, 68.04176f));
			list8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.72223f, 67.72225f));
			list8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.61111f, 67.72225f));
			list8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.61111f, -57.18049f));
			list8.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.61112f, -57.8195f));
			list8.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.61112f, -43.125f));
			list8.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.61112f, -28.11113f));
			list8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-71.66666f, -27.47211f));
			list8.Add(new Assets.Scripts.Simulation.SMath.Vector2(-72.77778f, 67.40275f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list8), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list9 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.05556f, -57.18049f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.22222f, -56.86113f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.00001f, -66.125f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(30.00001f, -76.02775f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.22222f, -88.16662f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.77777f, -91.68063f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(10.55555f, -91.36112f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-1.944441f, -89.4445f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-11.38889f, -83.375f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.44444f, -73.15275f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.22222f, -63.56937f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-24.16667f, -56.54162f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-37.5f, -56.54162f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.16667f, -53.66662f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-44.44445f, -102.2223f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.72222f, -94.875f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.88889f, -93.59725f));
			list9.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.33333f, -57.5f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list9), 2f, AreaType.land, 0f, null, null, null, false, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list10 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-16.38889f, -58.13887f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-14.44445f, -68.68049f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-11.11111f, -77.30563f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-2.777776f, -83.375f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(7.499993f, -86.88887f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(17.77777f, -87.20824f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.44444f, -78.26387f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.99999f, -64.52775f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(24.16667f, -60.6945f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(21.94444f, -57.8195f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(28.05555f, -57.18049f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(27.49999f, -61.65274f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(32.5f, -69.31937f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(29.44445f, -76.02775f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(26.94445f, -87.52775f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(11.94445f, -91.68063f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(0.8333266f, -91.04162f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-5.555552f, -89.125f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-13.33333f, -80.18049f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-20f, -71.875f));
			list10.Add(new Assets.Scripts.Simulation.SMath.Vector2(-22.77777f, -57.8195f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list10), 2f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list11 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list11.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.7222f, -14.69451f));
			list11.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.83333f, -14.69451f));
			list11.Add(new Assets.Scripts.Simulation.SMath.Vector2(70.83333f, -1.277747f));
			list11.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.16667f, 15.33338f));
			list11.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.1667f, 15.01387f));
			list11.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.1667f, -0.3195068f));
			list11.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.7222f, -14.69451f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list11), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list12 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.44444f, 1.91662f));
			list12.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.111114f, 1.277887f));
			list12.Add(new Assets.Scripts.Simulation.SMath.Vector2(1.388884f, 91.36112f));
			list12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-19.44444f, 91.68063f));
			list12.Add(new Assets.Scripts.Simulation.SMath.Vector2(-18.88889f, 2.555493f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list12), 2f, AreaType.land, 0f, null, null, null, false, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list13 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list13.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.33334f, 1.597253f));
			list13.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.61111f, 91.36112f));
			list13.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.33333f, 91.36112f));
			list13.Add(new Assets.Scripts.Simulation.SMath.Vector2(53.05556f, 1.91662f));
			list13.Add(new Assets.Scripts.Simulation.SMath.Vector2(23.33334f, 1.91662f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list13), 2f, AreaType.land, 0f, null, null, null, false, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list14 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list14.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.88888f, 15.65289f));
			list14.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.16667f, 72.1945f));
			list14.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.1667f, 70.59725f));
			list14.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.1667f, 15.01387f));
			list14.Add(new Assets.Scripts.Simulation.SMath.Vector2(79.16667f, 15.01387f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list14), 2f, AreaType.land, 0f, null, null, null, false, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list15 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list15.Add(new Assets.Scripts.Simulation.SMath.Vector2(135.5556f, -15.33324f));
			list15.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.1667f, -15.65275f));
			list15.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.8889f, -93.27775f));
			list15.Add(new Assets.Scripts.Simulation.SMath.Vector2(135.2778f, -93.27775f));
			list15.Add(new Assets.Scripts.Simulation.SMath.Vector2(135.2778f, -15.65275f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list15), 2f, AreaType.land, 0f, null, null, null, false, false, default));
			Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2> list16 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
			list16.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.1667f, -94.55549f));
			list16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-39.44444f, -94.55549f));
			list16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.22222f, -109.25f));
			list16.Add(new Assets.Scripts.Simulation.SMath.Vector2(-47.22222f, -114.6805f));
			list16.Add(new Assets.Scripts.Simulation.SMath.Vector2(150f, -114.6805f));
			list16.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.8889f, -94.23598f));
			list.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(list16), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
			return list.ToArray();
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

