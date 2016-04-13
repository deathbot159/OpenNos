//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Skill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Skill()
        {
            this.characterskill = new HashSet<CharacterSkill>();
            this.shopskill = new HashSet<ShopSkill>();
            this.npcmonsterskill = new HashSet<NpcMonsterSkill>();
            this.combo = new HashSet<Combo>();
        }
    
        public short SkillVNum { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public byte LevelMinimum { get; set; }
        public byte Class { get; set; }
        public byte MinimumAdventurerLevel { get; set; }
        public byte MinimumSwordmanLevel { get; set; }
        public byte MinimumArcherLevel { get; set; }
        public byte MinimumMagicianLevel { get; set; }
        public short Effect { get; set; }
        public byte Level { get; set; }
        public short MpCost { get; set; }
        public byte CPCost { get; set; }
        public short Cooldown { get; set; }
        public short CastAnimation { get; set; }
        public short AttackAnimation { get; set; }
        public short CastEffect { get; set; }
        public byte TargetRange { get; set; }
        public byte TargetType { get; set; }
        public byte HitType { get; set; }
        public short Duration { get; set; }
        public short Damage { get; set; }
        public short ElementalDamage { get; set; }
        public byte Element { get; set; }
        public short CastId { get; set; }
        public byte Type { get; set; }
        public byte SkillType { get; set; }
        public byte Range { get; set; }
        public short VNumRequired { get; set; }
        public short UpgradeSkill { get; set; }
        public short CastTime { get; set; }
        public int Buff { get; set; }
        public short BuffId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CharacterSkill> characterskill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShopSkill> shopskill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NpcMonsterSkill> npcmonsterskill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Combo> combo { get; set; }
    }
}
