using UnityEngine; 
using ThunderRoad;

namespace BasAimbot
{
    public class Fireball : ThunderScript
    {


        public override void ScriptLoaded(ModManager.ModData modData)
        {
            base.ScriptLoaded(modData);
            EventManager.OnSpellUsed += OnSpellUsed; 
        }

        private void OnSpellUsed(string spellID, Creature creature, Side side)
        {
            Debug.Log($"Spell used: {spellID}"); 
            if (spellID != "Fire") return; 
        }
    }
}
