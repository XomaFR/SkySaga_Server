﻿namespace SkySaga.Game;

// Client < > Server
public enum PacketId : byte
{
    SentErrorToClient,                      // [C <  S]
    ClientConnected,                        // [C  > S]
    ClientReadyToSync,                      // [C  > S]
    ClientReadyToPlay,                      // [C  > S]
    ClientInitialSyncFinished,              // [C  > S]
    ClientEntitiesSyncFinished,             // [C <  S]
    MapDefinition,                          // [C <  S]
    BeginSync,                              // [C <  S]
    ChunkSync,                              // [C <  S]
    PartialChunkEditsSync,                  // [C <  S]
    RequestWorldTeleport,                   // [C  > S]
    RequestCharacterServerTeleport,         // [C  > S]
    TransferToServer,                       // [C <  S]
    RequestEquipInventoryItem,              // [C  > S]
    RequestUnEquipInventoryItem,            // [C  > S]
    RequestUISettingsSlotChange,            // [C  > S]
    RequestUISettingsSetActiveSlot,         // [C  > S]
    PerformVoxelActions,                    // [C  > S]
    PerformEntityActions,                   // [C  > S]
    PerformAlwaysActions,                   // [C  > S]
    InteractWithEntity,                     // [C  > S]
    SetCurrentEmote,                        // [C  > S]
    TeleportBegins,                         // [C <> S]
    KillOccurred,                           // [C <  S]
    IFellTooFar,                            // [C  > S]
    PlayerJoined,                           // [C <  S]
    PlayerLeft,                             // [C <  S]
    DebugRequestBasicGearLoadout,           // [C ?? S]
    DebugRequestFinishTutorial,             // [C ?? S]
    DebugRequestPVPLoadout,                 // [C ?? S]
    DebugRequestAddItemToInventory,         // [C ?? S]
    DebugEnableMechanic,                    // [C ?? S]
    CombatBlock,                            // [C <  S]
    CombatParry,                            // [C <  S]
    EventEffect,                            // [C <  S]
    SetPlayerState,                         // [C  > S]
    SetPlayerMentalState,                   // [C  > S]
    SetCharacterCustomisationData,          // [C  > S]
    CharacterStatePitchChanged,             // [C  > S]
    QueueRecipeOnEntity,                    // [C  > S]
    CollectCraftedItemInSlot,               // [C  > S]
    CraftingQueryQueue,                     // [C  > S]
    CraftingFailed,                         // [C <  S]
    NewResourceEncountered,                 // [C <  S]
    InventoryItemDrop,                      // [C  > S]
    InventoryItemDestroy,                   // [C  > S]
    AdventureResultsViewed,                 // [C  > S]
    ShowingJobChallengesCompleted,          // [C  > S]
    AssignCollectionResourcePickup,         // [C  > S]
    FinalizeCollectionResourcePickup,       // [C  > S]
    InventoryItemTransfer,                  // [C  > S]
    InventoryItemTransferToSlot,            // [C  > S]
    InventoryItemTransferAll,               // [C  > S]
    InventoryItemSwap,                      // [C  > S]
    InventoryItemQueryContents,             // [C  > S]
    StorageItemSell,                        // [C  > S]
    StorageItemBuy,                         // [C  > S]
    TimeSync,                               // [C <  S]
    ServerInfo,                             // [C <  S]
    EntityEvent,                            // [C <  S]
    EquippedItemUsed,                       // [C  > S]
    StopUsingEquippedItem,                  // [C  > S]
    EntityUsedEquippedItem,                 // [C <  S]
    EntityStoppedUsingEquippedItem,         // [C <  S]
    ExecuteEntityAction,                    // [C  > S]
    EquipLocationUsedResponse,              // [C ?? S]
    SendBroadcastMessage,                   // [C <  S]
    CraftingNotification,                   // [C <  S]
    GetUserToken,                           // [C <  S]
    SetUserToken,                           // [C  > S]
    ApplyImpulse,                           // [C <  S]
    SetTimeStretch,                         // [C ?? S]
    TemperaturePing,                        // [C <  S]
    CoreTemperatureAdjustment,              // [C <  S]
    AllowFriendToEditHomeIsland,            // [C  > S]
    NewFriendRequest,                       // [C <  S]
    ActivateTimedChallenges,                // [C  > S]
    RechargeLifeTickets,                    // [C  > S]
    PvPPlayerJoinedTeam,                    // [C <  S]
    PvPPlayerLeftTeam,                      // [C <  S]
    PvPPlayerRequestJoinTeam,               // [C  > S]
    PvPWaitingInfo,                         // [C <  S]
    ChangePvPSettings,                      // [C ?? S]
    JoinPvPWorld,                           // [C  > S]
    JoinHomeWorld,                          // [C  > S]
    QuitGame,                               // [C <> S]
    DebugSetTeleporterTarget,               // [C ?? S]
    RequestRespawn,                         // [C  > S]
    GetPvPWorldInfo,                        // [C ?? S]
    PvPWorldInfo,                           // [C ?? S]
    PvPRoundInfo,                           // [C <  S]
    RequestChatChannelData,                 // [C  > S]
    SendChatChannelData,                    // [C <  S]
    NewMailRecieved,                        // [C <  S]
    MailRead,                               // [C  > S]
    MailGiftSelected,                       // [C  > S]
    MailCheck,                              // [C  > S]
    DeleteMail,                             // [C  > S]
    TakeMailAttachment,                     // [C  > S]
    RemoteMailSynced,                       // [C <  S]
    EntityAdd,                              // [C <  S]
    EntitySync,                             // [C <  S]
    EntityMoved,                            // [C  > S]
    EntityRemoved,                          // [C <  S]
    SetClientEntity,                        // [C <  S]
    PlayerSpawned,                          // [C <  S]
    SetLookAtDirection,                     // [C  > S]
    SavePlayerData,                         // [C ?? S]
    SaveCharacterName,                      // [C  > S]
    CharcterCreationResponse,               // [C <  S]
    CreateHomeworld,                        // [C  > S]
    DebugRequestAddEntity,                  // [C ?? S]
    RequestAITree,                          // [C ?? S]
    ReturnAIInfo,                           // [C ?? S]
    DebugSetJobRank,                        // [C ?? S]
    DebugSetJobChallengeProgress,           // [C ?? S]
    DebugActivateJobChallenge,              // [C ?? S]
    DebugResetJobChallenge,                 // [C ?? S]
    DebugCompleteJobChallenge,              // [C ?? S]
    DebugDeactivateJobChallenge,            // [C ?? S]
    DebugForceActivateTimedChallenges,      // [C ?? S]
    DebugForceSendTimedAdventureStartMail,  // [C ?? S]
    DebugSetEasyBuilding,                   // [C ?? S]
    DebugLearnRecipe,                       // [C ?? S]
    DebugForgetRecipe,                      // [C ?? S]
    DebugStartAdventure,                    // [C ?? S]
    DebugEndAdventure,                      // [C ?? S]
    EnableDebugRendering,                   // [C ?? S]
    AddDebugPrimitiveAABox,                 // [C ?? S]
    AddDebugPrimitiveLine,                  // [C ?? S]
    AddDebugPrimitiveSphere,                // [C ?? S]
    AddDebugPrimitiveText,                  // [C ?? S]
    AddDebugPrimitiveTriangle,              // [C ?? S]
    RemoveDebugPrimitive,                   // [C ?? S]
    ChangeDebugPrimitive,                   // [C ?? S]
    DebugSetTimeOfDay,                      // [C ?? S]
    ServerStats,                            // [C ?? S]
    ServerProfiles,                         // [C ?? S]
    RequestServerProfiles,                  // [C ?? S]
    DebugPopulateLoadout,                   // [C ?? S]
    DebugEquipmentChanged,                  // [C ?? S]
    DebugSetPlayerEntity,                   // [C ?? S]
    DebugSuicide,                           // [C ?? S]
    DebugSetDurabilityHealthFraction,       // [C ?? S]
    EquipmentMaterialChanged,               // [C  > S]
    TodoListTaskErase,                      // [C  > S]
    TodoListTaskAdd,                        // [C  > S]
    TodoListTaskRemove,                     // [C  > S]
    TodoListTaskReAdd,                      // [C  > S]
    SetSecondsPerPotentialHealthTransfer,   // [C ?? S]
    NotifyPhotoCaptured,                    // [C  > S]
    PhotoDelete,                            // [C  > S]
    PhotoValidated,                         // [C <  S]
    MoveItemToCraftingDropSlot,             // [C  > S]
    RemoveItemFromCraftingDropSlot,         // [C  > S]
    PerformCraftingDropSlotAction,          // [C  > S]
    PlayerFallenOffTheWorld,                // [C  > S]
    PlayerAcceptedNPCFriend,                // [C  > S]
    PlayerDodged,                           // [C  > S]
    EntityDodged,                           // [C <  S]
    StaminaConsumed                         // [C <  S]
}