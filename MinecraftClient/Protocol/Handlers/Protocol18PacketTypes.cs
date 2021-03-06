﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftClient.Protocol.Handlers
{
    /// <summary>
    /// Contains packet ID mappings for Protocol18
    /// </summary>
    class Protocol18PacketTypes
    {
        /// <summary>
        /// Get abstract numbering of the specified packet ID
        /// </summary>
        /// <param name="packetID">Packet ID</param>
        /// <param name="protocol">Protocol version</param>
        /// <returns>Abstract numbering</returns>
        public static PacketIncomingType GetPacketIncomingType(int packetID, int protocol)
        {
            if (protocol <= Protocol18Handler.MC18Version) // MC 1.7 and 1.8
            {
                switch (packetID)
                {
                    case 0x00: return PacketIncomingType.KeepAlive;
                    case 0x01: return PacketIncomingType.JoinGame;
                    case 0x02: return PacketIncomingType.ChatMessage;
                    case 0x07: return PacketIncomingType.Respawn;
                    case 0x08: return PacketIncomingType.PlayerPositionAndLook;
                    case 0x21: return PacketIncomingType.ChunkData;
                    case 0x22: return PacketIncomingType.MultiBlockChange;
                    case 0x23: return PacketIncomingType.BlockChange;
                    case 0x26: return PacketIncomingType.MapChunkBulk;
                    case 0x30: return PacketIncomingType.WindowItems;
                    //UnloadChunk does not exists prior to 1.9
                    case 0x38: return PacketIncomingType.PlayerListUpdate;
                    case 0x3A: return PacketIncomingType.TabCompleteResult;
                    case 0x3F: return PacketIncomingType.PluginMessage;
                    case 0x40: return PacketIncomingType.KickPacket;
                    case 0x46: return PacketIncomingType.NetworkCompressionTreshold;
                    case 0x48: return PacketIncomingType.ResourcePackSend;
                    case 0x2D: return PacketIncomingType.OpenWindow;
                    case 0x2E: return PacketIncomingType.CloseWindow;
                    case 0x2F: return PacketIncomingType.SetSlot;

                    // Set Cooldown does not exists
                    case 0x03: return PacketIncomingType.TimeUpdate;
                    // Entity handling
                    case 0x0E: return PacketIncomingType.SpawnEntity; // for non-living entity
                    case 0x0F: return PacketIncomingType.SpawnLivingEntity; // for living entity
                    case 0x05: return PacketIncomingType.SpawnPlayer;
                    case 0x13: return PacketIncomingType.DestroyEntities;
                    case 0x15: return PacketIncomingType.EntityPosition;
                    case 0x17: return PacketIncomingType.EntityPositionAndRotation;
                    case 0x20: return PacketIncomingType.EntityProperties;
                    case 0x18: return PacketIncomingType.EntityTeleport;
                    default: return PacketIncomingType.UnknownPacket;
                }
            }
            else if (protocol <= Protocol18Handler.MC1112Version) // MC 1.9, 1.10 and 1.11
            {
                switch (packetID)
                {
                    case 0x1F: return PacketIncomingType.KeepAlive;
                    case 0x23: return PacketIncomingType.JoinGame;
                    case 0x0F: return PacketIncomingType.ChatMessage;
                    case 0x33: return PacketIncomingType.Respawn;
                    case 0x2E: return PacketIncomingType.PlayerPositionAndLook;
                    case 0x20: return PacketIncomingType.ChunkData;
                    case 0x10: return PacketIncomingType.MultiBlockChange;
                    case 0x0B: return PacketIncomingType.BlockChange;
                    //MapChunkBulk removed in 1.9
                    case 0x1D: return PacketIncomingType.UnloadChunk;
                    case 0x2D: return PacketIncomingType.PlayerListUpdate;
                    case 0x0E: return PacketIncomingType.TabCompleteResult;
                    case 0x18: return PacketIncomingType.PluginMessage;
                    case 0x1A: return PacketIncomingType.KickPacket;
                    case 0x12: return PacketIncomingType.CloseWindow;
                    case 0x13: return PacketIncomingType.OpenWindow;
                    case 0x14: return PacketIncomingType.WindowItems;
                    case 0x16: return PacketIncomingType.SetSlot;
                    //NetworkCompressionTreshold removed in 1.9
                    case 0x32: return PacketIncomingType.ResourcePackSend;

                    case 0x17: return PacketIncomingType.SetCooldown;
                    case 0x44: return PacketIncomingType.TimeUpdate;
                    // Entity handling
                    case 0x00: return PacketIncomingType.SpawnEntity; // for non-living entity
                    case 0x03: return PacketIncomingType.SpawnLivingEntity; // for living entity
                    case 0x05: return PacketIncomingType.SpawnPlayer;
                    case 0x30: return PacketIncomingType.DestroyEntities;
                    case 0x25: return PacketIncomingType.EntityPosition;
                    case 0x26: return PacketIncomingType.EntityPositionAndRotation;
                    case 0x4A: return PacketIncomingType.EntityProperties;
                    case 0x49: return PacketIncomingType.EntityTeleport;
                    default: return PacketIncomingType.UnknownPacket;
                }
            }
            else if (protocol <= Protocol18Handler.MC112Version) // MC 1.12.0
            {
                switch (packetID)
                {
                    case 0x1F: return PacketIncomingType.KeepAlive;
                    case 0x23: return PacketIncomingType.JoinGame;
                    case 0x0F: return PacketIncomingType.ChatMessage;
                    case 0x34: return PacketIncomingType.Respawn;
                    case 0x2E: return PacketIncomingType.PlayerPositionAndLook;
                    case 0x20: return PacketIncomingType.ChunkData;
                    case 0x10: return PacketIncomingType.MultiBlockChange;
                    case 0x14: return PacketIncomingType.WindowItems;
                    case 0x16: return PacketIncomingType.SetSlot;
                    case 0x0B: return PacketIncomingType.BlockChange;
                    case 0x1D: return PacketIncomingType.UnloadChunk;
                    case 0x2D: return PacketIncomingType.PlayerListUpdate;
                    case 0x0E: return PacketIncomingType.TabCompleteResult;
                    case 0x18: return PacketIncomingType.PluginMessage;
                    case 0x1A: return PacketIncomingType.KickPacket;
                    case 0x12: return PacketIncomingType.CloseWindow;
                    case 0x13: return PacketIncomingType.OpenWindow;
                    case 0x33: return PacketIncomingType.ResourcePackSend;

                    case 0x17: return PacketIncomingType.SetCooldown;
                    case 0x46: return PacketIncomingType.TimeUpdate;
                    // Entity handling
                    case 0x00: return PacketIncomingType.SpawnEntity; // for non-living entity
                    case 0x03: return PacketIncomingType.SpawnLivingEntity; // for living entity
                    case 0x05: return PacketIncomingType.SpawnPlayer;
                    case 0x31: return PacketIncomingType.DestroyEntities;
                    case 0x26: return PacketIncomingType.EntityPosition;
                    case 0x27: return PacketIncomingType.EntityPositionAndRotation;
                    case 0x4D: return PacketIncomingType.EntityProperties;
                    case 0x4B: return PacketIncomingType.EntityTeleport;
                    default: return PacketIncomingType.UnknownPacket;
                }
            }
            else if (protocol <= Protocol18Handler.MC1122Version) // MC 1.12.2
            {
                switch (packetID)
                {
                    case 0x1F: return PacketIncomingType.KeepAlive;
                    case 0x23: return PacketIncomingType.JoinGame;
                    case 0x0F: return PacketIncomingType.ChatMessage;
                    case 0x35: return PacketIncomingType.Respawn;
                    case 0x2F: return PacketIncomingType.PlayerPositionAndLook;
                    case 0x20: return PacketIncomingType.ChunkData;
                    case 0x10: return PacketIncomingType.MultiBlockChange;
                    case 0x0B: return PacketIncomingType.BlockChange;
                    case 0x1D: return PacketIncomingType.UnloadChunk;
                    case 0x2E: return PacketIncomingType.PlayerListUpdate;
                    case 0x0E: return PacketIncomingType.TabCompleteResult;
                    case 0x18: return PacketIncomingType.PluginMessage;
                    case 0x1A: return PacketIncomingType.KickPacket;
                    case 0x12: return PacketIncomingType.CloseWindow;
                    case 0x13: return PacketIncomingType.OpenWindow;
                    case 0x14: return PacketIncomingType.WindowItems;
                    case 0x16: return PacketIncomingType.SetSlot;
                    case 0x34: return PacketIncomingType.ResourcePackSend;

                    case 0x17: return PacketIncomingType.SetCooldown;
                    case 0x47: return PacketIncomingType.TimeUpdate;
                    // Entity handling
                    case 0x00: return PacketIncomingType.SpawnEntity; // for non-living entity
                    case 0x03: return PacketIncomingType.SpawnLivingEntity; // for living entity
                    case 0x05: return PacketIncomingType.SpawnPlayer;
                    case 0x32: return PacketIncomingType.DestroyEntities;
                    case 0x26: return PacketIncomingType.EntityPosition;
                    case 0x27: return PacketIncomingType.EntityPositionAndRotation;
                    case 0x4E: return PacketIncomingType.EntityProperties;
                    case 0x4C: return PacketIncomingType.EntityTeleport;
                    default: return PacketIncomingType.UnknownPacket;
                }
            }
            else if (protocol < Protocol18Handler.MC114Version) // MC 1.13 to 1.13.2
            {
                switch (packetID)
                {
                    case 0x21: return PacketIncomingType.KeepAlive;
                    case 0x25: return PacketIncomingType.JoinGame;
                    case 0x0E: return PacketIncomingType.ChatMessage;
                    case 0x38: return PacketIncomingType.Respawn;
                    case 0x32: return PacketIncomingType.PlayerPositionAndLook;
                    case 0x22: return PacketIncomingType.ChunkData;
                    case 0x0F: return PacketIncomingType.MultiBlockChange;
                    case 0x0B: return PacketIncomingType.BlockChange;
                    case 0x1F: return PacketIncomingType.UnloadChunk;
                    case 0x30: return PacketIncomingType.PlayerListUpdate;
                    case 0x10: return PacketIncomingType.TabCompleteResult;
                    case 0x19: return PacketIncomingType.PluginMessage;
                    case 0x1B: return PacketIncomingType.KickPacket;
                    case 0x37: return PacketIncomingType.ResourcePackSend;
                    case 0x13: return PacketIncomingType.CloseWindow;
                    case 0x14: return PacketIncomingType.OpenWindow;
                    case 0x15: return PacketIncomingType.WindowItems;
                    case 0x17: return PacketIncomingType.SetSlot;

                    case 0x18: return PacketIncomingType.SetCooldown;
                    case 0x4A: return PacketIncomingType.TimeUpdate;
                    // Entity handling
                    case 0x00: return PacketIncomingType.SpawnEntity; // for non-living entity
                    case 0x03: return PacketIncomingType.SpawnLivingEntity; // for living entity
                    case 0x05: return PacketIncomingType.SpawnPlayer;
                    case 0x35: return PacketIncomingType.DestroyEntities;
                    case 0x28: return PacketIncomingType.EntityPosition;
                    case 0x29: return PacketIncomingType.EntityPositionAndRotation;
                    case 0x52: return PacketIncomingType.EntityProperties;
                    case 0x50: return PacketIncomingType.EntityTeleport;
                    default: return PacketIncomingType.UnknownPacket;
                }
            }
            else if (protocol < Protocol18Handler.MC115Version) // MC 1.14 to 1.14.4
            {
                switch (packetID)
                {
                    case 0x20: return PacketIncomingType.KeepAlive;
                    case 0x25: return PacketIncomingType.JoinGame;
                    case 0x0E: return PacketIncomingType.ChatMessage;
                    case 0x3A: return PacketIncomingType.Respawn;
                    case 0x35: return PacketIncomingType.PlayerPositionAndLook;
                    case 0x21: return PacketIncomingType.ChunkData;
                    case 0x0F: return PacketIncomingType.MultiBlockChange;
                    case 0x0B: return PacketIncomingType.BlockChange;
                    case 0x1D: return PacketIncomingType.UnloadChunk;
                    case 0x33: return PacketIncomingType.PlayerListUpdate;
                    case 0x10: return PacketIncomingType.TabCompleteResult;
                    case 0x18: return PacketIncomingType.PluginMessage;
                    case 0x1A: return PacketIncomingType.KickPacket;
                    case 0x39: return PacketIncomingType.ResourcePackSend;
                    case 0x2E: return PacketIncomingType.OpenWindow;
                    case 0x13: return PacketIncomingType.CloseWindow;
                    case 0x14: return PacketIncomingType.WindowItems;
                    case 0x16: return PacketIncomingType.SetSlot;
                    case 0x17: return PacketIncomingType.SetCooldown;
                    case 0x4E: return PacketIncomingType.TimeUpdate;
                    // Entity handling
                    case 0x00: return PacketIncomingType.SpawnEntity; // for non-living entity
                    case 0x03: return PacketIncomingType.SpawnLivingEntity; // for living entity
                    case 0x05: return PacketIncomingType.SpawnPlayer;
                    case 0x37: return PacketIncomingType.DestroyEntities;
                    case 0x28: return PacketIncomingType.EntityPosition;
                    case 0x29: return PacketIncomingType.EntityPositionAndRotation;
                    case 0x58: return PacketIncomingType.EntityProperties;
                    case 0x56: return PacketIncomingType.EntityTeleport;
                    default: return PacketIncomingType.UnknownPacket;
                }
            }
            else // MC 1.15
            {
                switch (packetID)
                {
                    case 0x21: return PacketIncomingType.KeepAlive;
                    case 0x26: return PacketIncomingType.JoinGame;
                    case 0x0F: return PacketIncomingType.ChatMessage;
                    case 0x3B: return PacketIncomingType.Respawn;
                    case 0x36: return PacketIncomingType.PlayerPositionAndLook;
                    case 0x22: return PacketIncomingType.ChunkData;
                    case 0x10: return PacketIncomingType.MultiBlockChange;
                    case 0x0C: return PacketIncomingType.BlockChange;
                    case 0x1E: return PacketIncomingType.UnloadChunk;
                    case 0x34: return PacketIncomingType.PlayerListUpdate;
                    case 0x11: return PacketIncomingType.TabCompleteResult;
                    case 0x19: return PacketIncomingType.PluginMessage;
                    case 0x1B: return PacketIncomingType.KickPacket;
                    case 0x3A: return PacketIncomingType.ResourcePackSend;
                    case 0x2F: return PacketIncomingType.OpenWindow;
                    case 0x14: return PacketIncomingType.CloseWindow;
                    case 0x15: return PacketIncomingType.WindowItems;
                    case 0x17: return PacketIncomingType.SetSlot;
                    case 0x18: return PacketIncomingType.SetCooldown;
                    case 0x4F: return PacketIncomingType.TimeUpdate;
                    // Entity handling
                    case 0x00: return PacketIncomingType.SpawnEntity; // for non-living entity
                    case 0x03: return PacketIncomingType.SpawnLivingEntity; // for living entity
                    case 0x05: return PacketIncomingType.SpawnPlayer;
                    case 0x38: return PacketIncomingType.DestroyEntities;
                    case 0x29: return PacketIncomingType.EntityPosition;
                    case 0x2A: return PacketIncomingType.EntityPositionAndRotation;
                    case 0x59: return PacketIncomingType.EntityProperties;
                    case 0x57: return PacketIncomingType.EntityTeleport;
                    case 0x1C: return PacketIncomingType.EntityStatus;
                    case 0x49: return PacketIncomingType.UpdateHealth; // TODO: Add backwards support
                    case 0x40: return PacketIncomingType.HeldItemChange; // TODO: Add backwards support
                    default: return PacketIncomingType.UnknownPacket;
                }
            }
        }

        /// <summary>
        /// Get packet ID of the specified outgoing packet
        /// </summary>
        /// <param name="packet">Abstract packet numbering</param>
        /// <param name="protocol">Protocol version</param>
        /// <returns>Packet ID</returns>
        public static int GetPacketOutgoingID(PacketOutgoingType packet, int protocol)
        {
            if (protocol <= Protocol18Handler.MC18Version) // MC 1.7 and 1.8
            {
                switch (packet)
                {
                    case PacketOutgoingType.KeepAlive: return 0x00;
                    case PacketOutgoingType.ResourcePackStatus: return 0x19;
                    case PacketOutgoingType.ChatMessage: return 0x01;
                    case PacketOutgoingType.ClientStatus: return 0x16;
                    case PacketOutgoingType.ClientSettings: return 0x15;
                    case PacketOutgoingType.PluginMessage: return 0x17;
                    case PacketOutgoingType.TabComplete: return 0x14;
                    case PacketOutgoingType.PlayerPosition: return 0x04;
                    case PacketOutgoingType.PlayerPositionAndLook: return 0x06;
                    case PacketOutgoingType.HeldItemChange: return 0x17;
                    case PacketOutgoingType.InteractEntity: return 0x02;
                    case PacketOutgoingType.TeleportConfirm: throw new InvalidOperationException("Teleport confirm is not supported in protocol " + protocol);
                    case PacketOutgoingType.ClickWindow: return 0x0E;
                    case PacketOutgoingType.CloseWindow: return 0x0D;
                }
            }
            else if (protocol <= Protocol18Handler.MC1112Version) // MC 1.9, 1,10 and 1.11
            {
                switch (packet)
                {
                    case PacketOutgoingType.KeepAlive: return 0x0B;
                    case PacketOutgoingType.ResourcePackStatus: return 0x16;
                    case PacketOutgoingType.ChatMessage: return 0x02;
                    case PacketOutgoingType.ClientStatus: return 0x03;
                    case PacketOutgoingType.ClientSettings: return 0x04;
                    case PacketOutgoingType.PluginMessage: return 0x09;
                    case PacketOutgoingType.TabComplete: return 0x01;
                    case PacketOutgoingType.PlayerPosition: return 0x0C;
                    case PacketOutgoingType.PlayerPositionAndLook: return 0x0D;
                    case PacketOutgoingType.TeleportConfirm: return 0x00;
                    case PacketOutgoingType.HeldItemChange: return 0x17;
                    case PacketOutgoingType.InteractEntity: return 0x0A;
                    case PacketOutgoingType.ClickWindow: return 0x07;
                    case PacketOutgoingType.CloseWindow: return 0x08;
                }
            }
            else if (protocol <= Protocol18Handler.MC112Version) // MC 1.12
            {
                switch (packet)
                {
                    case PacketOutgoingType.KeepAlive: return 0x0C;
                    case PacketOutgoingType.ResourcePackStatus: return 0x18;
                    case PacketOutgoingType.ChatMessage: return 0x03;
                    case PacketOutgoingType.ClientStatus: return 0x04;
                    case PacketOutgoingType.ClientSettings: return 0x05;
                    case PacketOutgoingType.PluginMessage: return 0x0A;
                    case PacketOutgoingType.TabComplete: return 0x02;
                    case PacketOutgoingType.PlayerPosition: return 0x0E;
                    case PacketOutgoingType.PlayerPositionAndLook: return 0x0F;
                    case PacketOutgoingType.TeleportConfirm: return 0x00;
                    case PacketOutgoingType.HeldItemChange: return 0x1A;
                    case PacketOutgoingType.InteractEntity: return 0x0B;
                    case PacketOutgoingType.ClickWindow: return 0x07;
                    case PacketOutgoingType.CloseWindow: return 0x08;
                }
            }
            else if (protocol <= Protocol18Handler.MC1122Version) // 1.12.2
            {
                switch (packet)
                {
                    case PacketOutgoingType.KeepAlive: return 0x0B;
                    case PacketOutgoingType.ResourcePackStatus: return 0x18;
                    case PacketOutgoingType.ChatMessage: return 0x02;
                    case PacketOutgoingType.ClientStatus: return 0x03;
                    case PacketOutgoingType.ClientSettings: return 0x04;
                    case PacketOutgoingType.PluginMessage: return 0x09;
                    case PacketOutgoingType.TabComplete: return 0x01;
                    case PacketOutgoingType.PlayerPosition: return 0x0D;
                    case PacketOutgoingType.PlayerPositionAndLook: return 0x0E;
                    case PacketOutgoingType.TeleportConfirm: return 0x00;
                    case PacketOutgoingType.HeldItemChange: return 0x1F;
                    case PacketOutgoingType.InteractEntity: return 0x0A;
                    case PacketOutgoingType.ClickWindow: return 0x07;
                    case PacketOutgoingType.CloseWindow: return 0x08;
                }
            }
            else if (protocol < Protocol18Handler.MC114Version) // MC 1.13 to 1.13.2
            {
                switch (packet)
                {
                    case PacketOutgoingType.KeepAlive: return 0x0E;
                    case PacketOutgoingType.ResourcePackStatus: return 0x1D;
                    case PacketOutgoingType.ChatMessage: return 0x02;
                    case PacketOutgoingType.ClientStatus: return 0x03;
                    case PacketOutgoingType.ClientSettings: return 0x04;
                    case PacketOutgoingType.PluginMessage: return 0x0A;
                    case PacketOutgoingType.TabComplete: return 0x05;
                    case PacketOutgoingType.PlayerPosition: return 0x10;
                    case PacketOutgoingType.PlayerPositionAndLook: return 0x11;
                    case PacketOutgoingType.TeleportConfirm: return 0x00;
                    case PacketOutgoingType.HeldItemChange: return 0x21;
                    case PacketOutgoingType.InteractEntity: return 0x0D;
                    case PacketOutgoingType.ClickWindow: return 0x08;
                    case PacketOutgoingType.CloseWindow: return 0x09;
                }
            }
            else // MC 1.14 to 1.15
            {
                switch (packet)
                {
                    case PacketOutgoingType.KeepAlive: return 0x0F;
                    case PacketOutgoingType.ResourcePackStatus: return 0x1F;
                    case PacketOutgoingType.ChatMessage: return 0x03;
                    case PacketOutgoingType.ClientStatus: return 0x04;
                    case PacketOutgoingType.ClientSettings: return 0x05;
                    case PacketOutgoingType.PluginMessage: return 0x0B;
                    case PacketOutgoingType.TabComplete: return 0x06;
                    case PacketOutgoingType.PlayerPosition: return 0x11;
                    case PacketOutgoingType.PlayerPositionAndLook: return 0x12;
                    case PacketOutgoingType.TeleportConfirm: return 0x00;
                    case PacketOutgoingType.HeldItemChange: return 0x23;
                    case PacketOutgoingType.InteractEntity: return 0x0E;
                    case PacketOutgoingType.UseItem: return 0x2D;
                    case PacketOutgoingType.PlayerBlockPlacement: return 0x2C;
                    case PacketOutgoingType.ClickWindow: return 0x09;
                    case PacketOutgoingType.CloseWindow: return 0x0A;
                }
            }

            throw new System.ComponentModel.InvalidEnumArgumentException("Unknown PacketOutgoingType (protocol=" + protocol + ")", (int)packet, typeof(PacketOutgoingType));
        }
    }
}
