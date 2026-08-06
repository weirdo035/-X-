using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using Dalamud.Interface.ManagedFontAtlas;
using KodakkuAssist.Data;
using KodakkuAssist.Module.Draw;
using KodakkuAssist.Module.GameEvent;
using KodakkuAssist.Script;
using KodakkuAssist.Extensions;
using Newtonsoft.Json;
using System.Runtime.Intrinsics.Arm;
using KodakkuAssist.Module.GameEvent.Struct;
using KodakkuAssist.Module.GameOperate;
using System.Collections.Concurrent;
using KodakkuAssist.Module.Draw.Manager;

namespace KodakkuAssistXSZYYS
{
    internal static class EOMineDatabase
    {
        public struct Mine
        {
            public Vector3 Position;
            public bool IsLarge;
        }

        public class MineGroup
        {
            public List<Mine> Mines = new List<Mine>();
        }

        // 数据已按地图ID分类
        public static readonly Dictionary<uint, List<MineGroup>> MinesByMap = new Dictionary<uint, List<MineGroup>>
        {
            // --- 地图 1178 数据 ---
            [1178] = new List<MineGroup>
            {
                // 组1：6个小雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(568.508f, -700f, 929.5f), IsLarge = false },
                    new Mine { Position = new Vector3(568.508f, -700f, 922.5f), IsLarge = false },
                    new Mine { Position = new Vector3(561.5f, -700f, 922.5f), IsLarge = false },
                    new Mine { Position = new Vector3(561.5f, -700f, 929.5f), IsLarge = false },
                    new Mine { Position = new Vector3(554.5f, -700f, 922.5f), IsLarge = false },
                    new Mine { Position = new Vector3(554.5f, -700f, 929.5f), IsLarge = false },
                }},
                // 组2：6个小雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(596.49f, -700.01f, 949.98f), IsLarge = false },
                    new Mine { Position = new Vector3(603.49f, -700f, 950f), IsLarge = false },
                    new Mine { Position = new Vector3(603.49f, -700f, 957f), IsLarge = false },
                    new Mine { Position = new Vector3(596.49f, -700f, 957f), IsLarge = false },
                    new Mine { Position = new Vector3(596.49f, -700f, 942.98f), IsLarge = false },
                    new Mine { Position = new Vector3(603.49f, -700f, 942.98f), IsLarge = false },
                }},
                // 组3：6个小雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(631.5f, -700f, 929.5f), IsLarge = false },
                    new Mine { Position = new Vector3(631.5f, -700f, 922.5f), IsLarge = false },
                    new Mine { Position = new Vector3(638.5f, -700f, 929.5f), IsLarge = false },
                    new Mine { Position = new Vector3(638.5f, -700f, 922.5f), IsLarge = false },
                    new Mine { Position = new Vector3(645.5f, -700f, 929.5f), IsLarge = false },
                    new Mine { Position = new Vector3(645.5f, -700f, 922.5f), IsLarge = false },
                }},
            },

            // --- 地图 1179 数据 ---
            [1179] = new List<MineGroup>
            {
                // 组1：9个大雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(386f, -700f, 792f), IsLarge = true },
                    new Mine { Position = new Vector3(393f, -700f, 792f), IsLarge = true },
                    new Mine { Position = new Vector3(400f, -700f, 792f), IsLarge = true },
                    new Mine { Position = new Vector3(386f, -700f, 785f), IsLarge = true },
                    new Mine { Position = new Vector3(393f, -700f, 785f), IsLarge = true },
                    new Mine { Position = new Vector3(400f, -700f, 785f), IsLarge = true },
                    new Mine { Position = new Vector3(386f, -700f, 778f), IsLarge = true },
                    new Mine { Position = new Vector3(393f, -700f, 778f), IsLarge = true },
                    new Mine { Position = new Vector3(400f, -700f, 778f), IsLarge = true },
                }},
                // 组2：4个小雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(364.98f, -698.02f, 805.48f), IsLarge = false },
                    new Mine { Position = new Vector3(371.98f, -698.02f, 805.48f), IsLarge = false },
                    new Mine { Position = new Vector3(364.98f, -698.02f, 798.48f), IsLarge = false },
                    new Mine { Position = new Vector3(371.98f, -698.02f, 798.48f), IsLarge = false },
                }},
                // 组3：2个小雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(561f, -680.08f, 832.49f), IsLarge = false },
                    new Mine { Position = new Vector3(561f, -680.08f, 825.49f), IsLarge = false },
                }},
                // 组4：4个小雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(364.98f, -698.02f, 765.5f), IsLarge = false },
                    new Mine { Position = new Vector3(371.98f, -698.02f, 765.5f), IsLarge = false },
                    new Mine { Position = new Vector3(364.98f, -698.02f, 758.5f), IsLarge = false },
                    new Mine { Position = new Vector3(371.98f, -698.02f, 758.5f), IsLarge = false },
                }},
                // 组5：6个小雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(482.5f, -680f, 732f), IsLarge = false },
                    new Mine { Position = new Vector3(476.5f, -680f, 735.5f), IsLarge = false },
                    new Mine { Position = new Vector3(463.5f, -680f, 732f), IsLarge = false },
                    new Mine { Position = new Vector3(476.5f, -680f, 728.5f), IsLarge = false },
                    new Mine { Position = new Vector3(469.5f, -680f, 735.5f), IsLarge = false },
                    new Mine { Position = new Vector3(469.5f, -680f, 728.5f), IsLarge = false },
                }},
                // 组6：6个大雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(469.5f, -680f, 780.5f), IsLarge = true },
                    new Mine { Position = new Vector3(469.5f, -680f, 787.5f), IsLarge = true },
                    new Mine { Position = new Vector3(476.5f, -680f, 787.5f), IsLarge = true },
                    new Mine { Position = new Vector3(482.5f, -680f, 784f), IsLarge = true },
                    new Mine { Position = new Vector3(476.5f, -680f, 780.5f), IsLarge = true },
                    new Mine { Position = new Vector3(463.5f, -680f, 784f), IsLarge = true },
                }},
            },

            // --- 地图 1181 数据 ---
            [1181] = new List<MineGroup>
            {
                // 组1：2个大雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(603.48f, -684.02f, 776f), IsLarge = true },
                    new Mine { Position = new Vector3(596.49f, -684.02f, 776f), IsLarge = true },
                }},
            },

            // --- 地图 1182 数据 ---
            [1182] = new List<MineGroup>
            {
                // 组1：6个大雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(677.49f, -700.01f, 116.99f), IsLarge = true },
                    new Mine { Position = new Vector3(677.49f, -700.01f, 123.99f), IsLarge = true },
                    new Mine { Position = new Vector3(677.49f, -700.01f, 130.99f), IsLarge = true },
                    new Mine { Position = new Vector3(670.49f, -700.01f, 116.99f), IsLarge = true },
                    new Mine { Position = new Vector3(670.49f, -700.01f, 123.99f), IsLarge = true },
                    new Mine { Position = new Vector3(670.49f, -700.01f, 130.99f), IsLarge = true },
                }},
                // 组2：6个大雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(634.49f, -700.01f, 131f), IsLarge = true },
                    new Mine { Position = new Vector3(634.49f, -700.01f, 123.99f), IsLarge = true },
                    new Mine { Position = new Vector3(634.49f, -700.01f, 117f), IsLarge = true },
                    new Mine { Position = new Vector3(641.49f, -700.01f, 131f), IsLarge = true },
                    new Mine { Position = new Vector3(641.49f, -700.01f, 123.99f), IsLarge = true },
                    new Mine { Position = new Vector3(641.49f, -700.01f, 117f), IsLarge = true },
                }},
                // 组3：4个小雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(568f, -700f, 127.5f), IsLarge = false },
                    new Mine { Position = new Vector3(568f, -700f, 120.5f), IsLarge = false },
                    new Mine { Position = new Vector3(561f, -700f, 127.5f), IsLarge = false },
                    new Mine { Position = new Vector3(561f, -700f, 120.5f), IsLarge = false },
                }},
                // 组4：5个大雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(528.31f, -700.01f, 129.66f), IsLarge = true },
                    new Mine { Position = new Vector3(534f, -700.01f, 123.97f), IsLarge = true },
                    new Mine { Position = new Vector3(539.69f, -700.01f, 129.66f), IsLarge = true },
                    new Mine { Position = new Vector3(528.31f, -700.01f, 118.28f), IsLarge = true },
                    new Mine { Position = new Vector3(539.69f, -700.01f, 118.28f), IsLarge = true },
                }},
                // 组5：9个小雷
                new MineGroup { Mines = {
                    new Mine { Position = new Vector3(617.98f, -700.04f, 123.98f), IsLarge = false },
                    new Mine { Position = new Vector3(610.98f, -700.04f, 123.98f), IsLarge = false },
                    new Mine { Position = new Vector3(600f, -700.07f, 112.99f), IsLarge = false },
                    new Mine { Position = new Vector3(584.99f, -700.01f, 131f), IsLarge = false },
                    new Mine { Position = new Vector3(588.98f, -700.07f, 123.98f), IsLarge = false },
                    new Mine { Position = new Vector3(614.98f, -700.01f, 116.99f), IsLarge = false },
                    new Mine { Position = new Vector3(614.98f, -700.01f, 131f), IsLarge = false },
                    new Mine { Position = new Vector3(581.98f, -700.07f, 123.98f), IsLarge = false },
                    new Mine { Position = new Vector3(584.99f, -700.01f, 116.98f), IsLarge = false },
                }},
            },
        };
    }

    [ScriptType(
        name: "超魔之塔排雷",
        guid: "874D3ECF-BD6B-448F-BB42-AE7F082E4999",
        territorys: [1346],
        version: "0.1.1",
        author: "jjcn",
        note: "自改XSZYYS力之塔扫雷脚本，坐标不全，且1.5暂只有左边，鸭嘴兽解谜只显示进出口与鸭嘴兽脚下，下为X佬力之塔原脚本介绍：在聊天栏输入[/e 新月排雷]即可开始排雷。再次输入可关闭显示。显示持续1800s，如果显示消失，则请重新输入。"
    )]
    public class 超魔之塔排雷
    {
        private bool _areMinesShown = false;
        private uint _currentMapId = 0;
        private readonly object _lock = new object();

        public void Init(ScriptAccessory accessory)
        {
            lock (_lock)
            {
                _areMinesShown = false;
                _currentMapId = 0;
            }
            accessory.Method.RemoveDraw(".*");
            accessory.Log.Debug("超魔之塔排雷脚本已初始化。");
        }

        [ScriptMethod(
            name: "切换地雷位置显示",
            eventType: EventTypeEnum.Chat,
            eventCondition: ["Type:Echo", "Message:新月排雷"]
        )]
        public void ToggleMineDisplay(Event @event, ScriptAccessory accessory)
        {
            lock (_lock)
            {
                if (!EOMineDatabase.MinesByMap.ContainsKey(_currentMapId))
                {
                    accessory.Method.TextInfo("当前地图无地雷数据。", 2000);
                    return;
                }

                _areMinesShown = !_areMinesShown;

                if (_areMinesShown)
                {
                    DrawMinesForMap(accessory, _currentMapId);
                    accessory.Method.TextInfo("显示地雷位置", 2000);
                }
                else
                {
                    accessory.Method.RemoveDraw("EO_Mine_.*");
                    accessory.Method.TextInfo("隐藏地雷位置", 2000);
                }
            }
        }

        #region Map Change Handlers

        [ScriptMethod(
            name: "进入区域 1178",
            eventType: EventTypeEnum.ChangeMap,
            eventCondition: ["MapId:1178"],
            userControl: false
        )]
        public void OnEnterMap1178(Event @event, ScriptAccessory accessory) 
            => HandleEnterMineMap(1178, accessory);

        [ScriptMethod(
            name: "进入区域 1179",
            eventType: EventTypeEnum.ChangeMap,
            eventCondition: ["MapId:1179"],
            userControl: false
        )]
        public void OnEnterMap1179(Event @event, ScriptAccessory accessory) 
            => HandleEnterMineMap(1179, accessory);

        [ScriptMethod(
            name: "进入区域 1181",
            eventType: EventTypeEnum.ChangeMap,
            eventCondition: ["MapId:1181"],
            userControl: false
        )]
        public void OnEnterMap1181(Event @event, ScriptAccessory accessory) 
            => HandleEnterMineMap(1181, accessory);

        [ScriptMethod(
            name: "进入区域 1182",
            eventType: EventTypeEnum.ChangeMap,
            eventCondition: ["MapId:1182"],
            userControl: false
        )]
        public void OnEnterMap1182(Event @event, ScriptAccessory accessory) 
            => HandleEnterMineMap(1182, accessory);

        #endregion

        private async void HandleEnterMineMap(uint mapId, ScriptAccessory accessory)
        {
            if (mapId == _currentMapId)
            {
                accessory.Log.Debug($"重复触发进入地图 {mapId} 事件，已忽略。");
                return;
            }

            uint newMapId;
            lock (_lock)
            {
                _currentMapId = mapId;
                newMapId = _currentMapId;
                accessory.Method.RemoveDraw("EO_.*");
            }

            await Task.Delay(50);

            lock (_lock)
            {
                if (_currentMapId != newMapId) return;

                _areMinesShown = true;
                DrawMinesForMap(accessory, newMapId);
                accessory.Method.TextInfo($"进入地雷区域 ({newMapId})，已自动显示标记。", 3000);
            }
        }

        [ScriptMethod(
            name: "大雷生成处理",
            eventType: EventTypeEnum.ObjectChanged,
            eventCondition: ["Operate:Add", "DataId:2014585"]
        )]
        public void OnLargeMineSpawn(Event @event, ScriptAccessory accessory)
        {
            HandleMineSpawn(@event.SourcePosition, true, accessory);
        }

        [ScriptMethod(
            name: "小雷生成处理",
            eventType: EventTypeEnum.ObjectChanged,
            eventCondition: ["Operate:Add", "DataId:2014584"]
        )]
        public void OnSmallMineSpawn(Event @event, ScriptAccessory accessory)
        {
            HandleMineSpawn(@event.SourcePosition, false, accessory);
        }

        private async void HandleMineSpawn(Vector3 spawnedPosition, bool isLargeSpawned, ScriptAccessory accessory)
        {
            if (!EOMineDatabase.MinesByMap.TryGetValue(_currentMapId, out var currentMapMines)) return;

            int groupIndex = 0;
            foreach (var group in currentMapMines)
            {
                int mineIndex = 0;
                foreach (var mine in group.Mines)
                {
                    if (Vector3.Distance(mine.Position, spawnedPosition) < 1.5f)
                    {
                        int innerMineIndex = 0;
                        foreach (var mineToClear in group.Mines)
                        {
                            accessory.Method.RemoveDraw($"EO_Mine_G{groupIndex}_M{innerMineIndex}");
                            innerMineIndex++;
                        }

                        await Task.Delay(50);

                        DrawPropertiesEdit dp = accessory.Data.GetDefaultDrawProperties();
                        dp.Name = $"EO_Explosion_G{groupIndex}_M{mineIndex}";
                        dp.Position = spawnedPosition;
                        dp.Color = new Vector4(1.0f, 0.0f, 0.0f, 0.6f);
                        dp.DestoryAt = 1000000;
                        dp.Scale = isLargeSpawned ? new Vector2(30f, 30f) : new Vector2(7f, 7f);

                        accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
                        return;
                    }
                    mineIndex++;
                }
                groupIndex++;
            }
        }

        private void DrawMinesForMap(ScriptAccessory accessory, uint mapId)
        {
            if (!EOMineDatabase.MinesByMap.TryGetValue(mapId, out var mineGroups)) return;

            const long displayDuration = 1800000;
            var smallMineColor = new Vector4(1.0f, 0.65f, 0.0f, 2.0f);
            var largeMineColor = new Vector4(0.86f, 0.08f, 0.23f, 2.0f);
            var smallMineRadius = new Vector2(4f, 4f);
            var largeMineRadius = new Vector2(4f, 4f);

            int groupIndex = 0;
            foreach (var group in mineGroups)
            {
                int mineIndex = 0;
                foreach (var mine in group.Mines)
                {
                    DrawPropertiesEdit dp = accessory.Data.GetDefaultDrawProperties();
                    dp.Name = $"EO_Mine_G{groupIndex}_M{mineIndex}";
                    dp.Position = mine.Position;
                    dp.DestoryAt = displayDuration;

                    if (mine.IsLarge)
                    {
                        dp.Color = largeMineColor;
                        dp.Scale = largeMineRadius;
                    }
                    else
                    {
                        dp.Color = smallMineColor;
                        dp.Scale = smallMineRadius;
                    }

                    accessory.Method.SendDraw(DrawModeEnum.Default, DrawTypeEnum.Circle, dp);
                    mineIndex++;
                }
                groupIndex++;
            }
        }

        [ScriptMethod(
            name: "盗贼扫雷",
            eventType: EventTypeEnum.ActionEffect,
            eventCondition: ["ActionId:41648"]
        )]
        public void OnThiefScan(Event @event, ScriptAccessory accessory)
        {
            if (!EOMineDatabase.MinesByMap.TryGetValue(_currentMapId, out var currentMapMines)) return;

            var scanPosition = @event.SourcePosition;
            const float scanRadius = 15f;

            int groupIndex = 0;
            foreach (var group in currentMapMines)
            {
                int mineIndex = 0;
                foreach (var mine in group.Mines)
                {
                    if (Vector3.Distance(mine.Position, scanPosition) <= scanRadius)
                    {
                        accessory.Method.RemoveDraw($"EO_Mine_G{groupIndex}_M{mineIndex}");
                    }
                    mineIndex++;
                }
                groupIndex++;
            }
        }

        [ScriptMethod(
            name: "猎人排雷",
            eventType: EventTypeEnum.ActionEffect,
            eventCondition: ["ActionId:41601"]
        )]
        public void OnHunterScan(Event @event, ScriptAccessory accessory)
        {
            if (!EOMineDatabase.MinesByMap.TryGetValue(_currentMapId, out var currentMapMines)) return;

            var scanPosition = @event.EffectPosition;
            const float scanRadius = 9f;

            int groupIndex = 0;
            foreach (var group in currentMapMines)
            {
                int mineIndex = 0;
                foreach (var mine in group.Mines)
                {
                    if (Vector3.Distance(mine.Position, scanPosition) <= scanRadius)
                    {
                        accessory.Method.RemoveDraw($"EO_Mine_G{groupIndex}_M{mineIndex}");
                    }
                    mineIndex++;
                }
                groupIndex++;
            }
        }

        [ScriptMethod(
            name: "雷爆炸",
            eventType: EventTypeEnum.ActionEffect,
            eventCondition: ["ActionId:regex:^(42050|42051)$"]
        )]
        public void OnMineExplosion(Event @event, ScriptAccessory accessory)
        {
            if (!EOMineDatabase.MinesByMap.TryGetValue(_currentMapId, out var currentMapMines)) return;

            var explosionPosition = @event.SourcePosition;

            int groupIndex = 0;
            foreach (var group in currentMapMines)
            {
                int mineIndex = 0;
                foreach (var mine in group.Mines)
                {
                    if (Vector3.Distance(mine.Position, explosionPosition) < 1.5f)
                    {
                        accessory.Method.RemoveDraw($"EO_Mine_G{groupIndex}_M{mineIndex}");
                        accessory.Method.RemoveDraw($"EO_Explosion_G{groupIndex}_M{mineIndex}");
                        return;
                    }
                    mineIndex++;
                }
                groupIndex++;
            }
        }
    }
}