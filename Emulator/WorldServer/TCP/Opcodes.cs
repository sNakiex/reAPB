﻿using System;

[Flags]
public enum Opcodes : uint
{
    //DONE - GC2WS
    ASK_WORLD_ENTER = 0xBB8,
    ASK_INSTANCE_LIST = 0xBBA,
    ASK_DISTRICT_ENTER = 0xBBD,
    ASK_DISTRICT_RESERVE = 0xBBB,
    LOGOUT = 0xBC0,
    ASK_FRIENDLIST_ADD = 0xBEC,
    ASK_FRIENDLIST_REMOVE = 0xBED,
    ASK_FRIENDLIST_STATE = 0xBEE,
    ASK_IGNORELIST_ADD = 0xBEF,
    ASK_IGNORELIST_REMOVE = 0xBF0,
    ASK_CHARACTERFINDER_INFO = 0xBF1,
    LFG = 0xC04,

    //DONE - WS2GC
    ANS_WORLD_ENTER = 0xFA3,
    ANS_INSTANCE_LIST = 0xFA7,
    DISTRICT_LIST = 0xFA6,
    ANS_DISTRICT_ENTER = 0xFAA,
    ANS_DISTRICT_RESERVE = 0xFA8,
    ANS_FRIENDLIST_ADD = 0xFF1,
    ANS_FRIENDLIST_REMOVE = 0xFF2,
    ANS_FRIENDLIST_STATE = 0xFF5,
    ANS_IGNORELIST_ADD = 0xFF8,
    ANS_IGNORELIST_REMOVE = 0xFF9,
    ANS_CHARACTERFINDER_INFO = 0xFFB,

    //NOT DONE - GC2WS (have to discover structure and opcode changes)
    ASK_WORLD_QUEUE_CANCEL = 0xBB9,
    ASK_DISTRICT_RESERVE_CANCEL = 0xBBC,
    ASK_DISTRICT_EXIT = 0xBBE,
    ASK_DISTRICT_QUEUE_CANCEL = 0xBBF,
    ASK_NAME_QUERY = 0xBC1,
    ASK_CHAT_WHISPER = 0xBC2,
    CHAT_GROUP = 0xBC3,
    CHAT_CLAN = 0xBC4,
    CHAT_OFFICER = 0xBC5,
    CHAT_DISTRICT = 0xBC6,
    CHAT_STATE = 0xBC7,
    ASK_GROUP_CONFIG = 0xBC8,
    ASK_GROUP_JOIN = 0xBC9,
    ASK_GROUP_INVITE = 0xBCA,
    ANS_GROUP_INVITE = 0xBCB,
    ASK_GROUP_LEAVE = 0xBCC,
    ASK_GROUP_REMOVE = 0xBCD,
    ASK_GROUP_LEADER = 0xBCE,
    ASK_GROUP_STATE = 0xBCF,
    ASK_GROUP_LIST = 0xBD0,
    ASK_GROUP_INFO = 0xBD1,
    ASK_CLAN_CREATE = 0xBD2,
    ASK_CLAN_DELETE = 0xBD3,
    ASK_CLAN_INVITE = 0xBD4,
    ANS_CLAN_INVITE = 0xBD5,
    ASK_CLAN_LEAVE = 0xBD6,
    ASK_CLAN_REMOVE = 0xBD7,
    ASK_CLAN_LEADER = 0xBD8,
    ASK_CLAN_BIO = 0xBD9,
    ASK_CLAN_BIO_EDIT = 0xBDA,
    ASK_CLAN_SYMBOL = 0xBDB,
    ASK_CLAN_SYMBOL_EDIT = 0xBDC,
    ASK_CLAN_THEME = 0xBDD,
    ASK_CLAN_THEME_EDIT = 0xBDE,
    ASK_CLAN_MEMBER_STATE = 0xBDF,
    ASK_CLAN_MEMBER_STATS = 0xBE0,
    ASK_CLAN_MEMBER_PROFILE = 0xBE1,
    ASK_CLAN_MEMBER_BIO_EDIT = 0xBE2,
    ASK_CLAN_MEMBER_NOTE_EDIT = 0xBE3,
    ASK_CLAN_RANK_CREATE = 0xBE4,
    ASK_CLAN_RANK_EDIT = 0xBE5,
    ASK_CLAN_RANK_DELETE = 0xBE6,
    ASK_CLAN_RANK_ASSIGN = 0xBE7,
    ASK_CLAN_INFORMATION = 0xBE8,
    ASK_CLAN_INFORMATION_EDIT = 0xBE9,
    ASK_CLAN_MOTD_EDIT = 0xBEA,
    ASK_MARKETPLACE_AUCTION_CANCEL = 0xBF1,
    ASK_MARKETPLACE_AUCTION_ITEM = 0xBF2,
    ASK_MARKETPLACE_AUCTION_LIST = 0xBF3,
    ASK_MARKETPLACE_MYAUCTION_LIST = 0xBF4,
    ASK_MARKETPLACE_MYBID_LIST = 0xBF5,
    ASK_MARKETPLACE_SELLER_LIST = 0xBF6,
    ASK_MAIL_LIST = 0xBF7,
    ASK_MAIL_READ = 0xBF8,
    ASK_MAIL_ITEM = 0xBF9,
    ASK_MAIL_DELETE = 0xBFA,
    ASK_CONFIGFILE_LOAD = 0xBFB,
    ASK_CONFIGFILE_SAVE = 0xBFC,
    ASK_CONFIG_SAVE = 0xBFD,
    ASK_LEAGUE_LIST = 0xBFE,
    ASK_LEAGUE_MYLEAGUE_LIST = 0xBFF,
    ASK_LEAGUE_VALUE = 0xC00,
    ASK_PLAYED = 0xC01,
    ASK_POPULATION = 0xC02,
    ASK_WHO = 0xC03,
    ASK_GM_COMMAND = 0xC04,
    ASK_SUBSCRIPTION_REMAINING_TIME = 0xC05,
    ASK_MARKETPLACE_THUMBNAIL = 0xC07,

    //NOT DONE - WS2GC (have to discover structure and opcode changes)
    ERROR = 0xFA0,
    KICK = 0xFA1,
    WORLD_SHUTDOWN_NOTIFY = 0xFA2,
    ANS_WORLD_QUEUE_CANCEL = 0xFA4,
    WORLD_QUEUE_STATUS = 0xFA5,
    ANS_DISTRICT_RESERVE_CANCEL = 0xFA9,
    ANS_DISTRICT_EXIT = 0xFAB,
    ANS_DISTRICT_QUEUE_CANCEL = 0xFAC,
    DISTRICT_QUEUE_STATUS = 0xFAD,
    ANS_NAME_QUERY = 0xFAE,
    ANS_CHAT_WHISPER = 0xFAF,
    CHAT_WHISPER = 0xFB0,
    CHAT_SYSTEM = 0xFB5,
    CHAT_AFK = 0xFB6,
    CHAT_DND = 0xFB7,
    CHAT_CONVERSATION_END = 0xFB8,
    ANS_GROUP_CONFIG = 0xFB9,
    ANS_GROUP_JOIN = 0xFBA,
    ANS_GROUP_LEAVE = 0xFBD,
    ANS_GROUP_REMOVE = 0xFBE,
    ANS_GROUP_LEADER = 0xFBD,
    ANS_GROUP_STATE = 0xFC0,
    ANS_GROUP_LIST = 0xFC1,
    ANS_GROUP_INFO = 0xFC2,
    GROUP_INFO = 0xFC3,
    GROUP_CONFIG = 0xFC4,
    GROUP_JOIN = 0xFC5,
    GROUP_LEAVE = 0xFC6,
    GROUP_REMOVE = 0xFC7,
    GROUP_LEADER = 0xFC8,
    GROUP_STATUS = 0xFC9,
    GROUP_INVITE_CANCELLED = 0xFCA,
    ANS_CLAN_CREATED = 0xFCB,
    ANS_CLAN_DELETE = 0xFCC,
    ANS_CLAN_INVITE1 = 0xFCE,
    ANS_CLAN_INVITE2 = 0xFCF,
    ANS_CLAN_REMOVE = 0xFD0,
    ANS_CLAN_LEADER = 0xFD1,
    ANS_CLAN_BIO = 0xFD2,
    ANS_CLAN_BIO_EDIT = 0xFD3,
    ANS_CLAN_SYMBOL = 0xFD4,
    ANS_CLAN_SYMBOL_EDIT = 0xFD5,
    ANS_CLAN_THEME = 0xFD6,
    ANS_CLAN_THEME_EDIT = 0xFD7,
    ANS_CLAN_MEMBER_STATE = 0xFD8,
    ANS_CLAN_MEMBER_STATS = 0xFD9,
    ANS_CLAN_MEMBER_PROFILE = 0xFDA,
    ANS_CLAN_MEMBER_BIO_EDIT = 0xFDB,
    ANS_CLAN_MEMBER_NOTE_EDIT = 0xFDC,
    ANS_CLAN_RANK_EDIT = 0xFDD,
    ANS_CLAN_RANK_CREATE = 0xFDE,
    ANS_CLAN_RANK_DELETE = 0xFDF,
    ANS_CLAN_RANK_ASSIGN = 0xFE0,
    ANS_CLAN_INFORMATION = 0xFE1,
    ANS_CLAN_INFORMATION_EDIT = 0xFE2,
    ANS_CLAN_MOTD_EDIT = 0xFE3,
    CLAN_RANK_INFO = 0xFE4,
    CLAN_INFO = 0xFE5,
    CLAN_MOTD = 0xFE6,
    CLAN_RANK_CREATE = 0xFE7,
    CLAN_RANK_DELETE = 0xFE8,
    CLAN_RANK_ASSIGN = 0xFE9,
    CLAN_RANK_EDIT = 0xFEA,
    CLAN_JOIN = 0xFEB,
    CLAN_LEAVE = 0xFEC,
    CLAN_REMOVE = 0xFED,
    CLAN_LEADER = 0xFEE,
    CLAN_DELETE = 0xFEF,
    CLAN_STATUS = 0xFF0,
    FRIENDLIST_INFO = 0xFF4,
    FRIENDLIST_STATUS = 0xFF5,
    IGNORELIST_INFO = 0xFF8,
    ANS_MARKETPLACE_AUCTION_CANCEL = 0xFFA,
    ANS_MARKETPLACE_AUCTION_ITEM = 0xFFB,
    ANS_MARKETPLACE_AUCTION_LIST = 0xFFC,
    ANS_MARKETPLACE_MYAUCTION_LIST = 0xFFD,
    ANS_MARKETPLACE_MYBID_LIST = 0xFFE,
    ANS_MARKETPLACE_SELLER_LIST = 0xFFF,
    MARKETPLACE_AUCTION_INFO = 0x1000,
    ANS_MAIL_LIST = 0x1001,
    ANS_MAIL_READ = 0x1002,
    ANS_MAIL_ITEM = 0x1003,
    ANS_MAIL_DELETE = 0x1004,
    MAIL_INFO = 0x1005,
    ANS_CONFIGFILE_LOAD = 0x1006,
    ANS_CONFIGFILE_SAVE = 0x1007,
    ANS_CONFIG_SAVE = 0x1008,
    ANS_LEAGUE_LIST = 0x1009,
    ANS_LEAGUE_MYLEAGUE_LIST = 0x100A,
    ANS_LEAGUE_VALUE = 0x100B,
    ANS_PLAYED = 0x100C,
    ANS_POPULATION = 0x100D,
    ANS_WHO = 0x100E,
    ANS_GM_COMMAND = 0x100F,
    ANS_SUBSCRIPTION_REMAINING_TIME = 0x1010,
    VOICE_CHANNEL_INFO = 0x1011,
    SUBSCRIPTION_INFO = 0x1012,
    MARKETPLACE_THUMBNAIL = 0x1013
};