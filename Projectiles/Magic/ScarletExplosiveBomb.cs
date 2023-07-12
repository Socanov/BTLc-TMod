using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace BTLc.Projectiles.Magic
{
    public class ScarletExplosiveBomb : BTLcProj
    {
        float d;
        float r = 0;
        float r2;
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
        }
        public override void SetDefaults()
        {
            Projectile.width = 40;
            Projectile.height = 40;
            Projectile.aiStyle = -1;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.DamageType = DamageClass.Magic;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 600;
            Projectile.alpha = 255;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = false;
            Projectile.light = 0.2f;
            base.SetDefaults();
        }
        public override void AI()
        {
            Player player = Main.player[Projectile.owner];
            if(Main.time % 2 == 0)
            {
                Dust duse = Dust.NewDustDirect(Projectile.Center, 20, 20, DustID.DynastyShingle_Red, 0, 0, 0, default);
                Lighting.AddLight(duse.position, new Vector3(Color.Red.R / 100f, Color.Red.G / 100f, Color.Red.B / 100f));
            }
            base.AI();
        }
        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            for(int i = 0; i < 50; i++)
            {
                
                r += MathHelper.TwoPi / 50;
                d = 14;
                Vector2 velocity = new Vector2((float)Math.Cos(r), (float)Math.Sin(r)) * 10f;
                Dust dust = Dust.NewDustPerfect(Projectile.Center, DustID.Bone, velocity, 0, Color.Red, 2f);
                dust.noGravity = true;
            }
            base.OnHitNPC(target, hit, damageDone);
        }
    }
}