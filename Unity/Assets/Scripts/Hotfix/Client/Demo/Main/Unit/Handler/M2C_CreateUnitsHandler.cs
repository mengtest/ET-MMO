﻿namespace ET.Client
{
    [MessageHandler(SceneType.Client)]
    public class M2C_CreateUnitsHandler: MessageHandler<Scene, M2C_CreateUnits>
    {
        protected override async ETTask Run(Scene root, M2C_CreateUnits message)
        {
            Scene currentScene = root.CurrentScene();
            UnitComponent unitComponent = currentScene.GetComponent<UnitComponent>();

            foreach (UnitInfo unitInfo in message.Units)
            {
                if (unitComponent.Get(unitInfo.UnitId) != null)
                {
                    continue;
                }

                Unit unit = UnitFactory.Create(currentScene, unitInfo);
                Log.Error("New Unit:"+unit.Id);
            }

            await ETTask.CompletedTask;
        }
    }
}