using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MyGame.DefGameBasic
{
    public class Const
    {
        //=======================Tag
        public const string PLAYER_TAG = "Player";
        public const string ENEMY_TAG = "Enemy";
        public const string ENEMY_WEAPON_TAG = "EnemyWeapon";

        //=====================Anim
        public const string ATTACK_ANIM = "Attack";
        public const string DEATH_ANIM = "Death";

        //=====================Player
        public const string DEATH_PLAYER = "DeathPlayer";

        //=====================Info
        public const string BEST_SCORE_PREF = "best_score";
        public const string PLAYER_PREFIX_PREF = "player";
        public const string CUR_PLAYER_ID_PREF = "cur_player_id";
        public const string COIN_PREF = "coins";
        public const string MUSIC_VOL_PREF = "music_vol";
        public const string SOUND_VOL_PREF = "sound_vol";
    }
}