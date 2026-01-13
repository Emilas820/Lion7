using System;

// 부모 클래스
class Character
{
    private int hp;
    
    // virtual 프로퍼티 (가상 함수 테이블에 등록됨!)
    public virtual int HP
    {
        get 
        { 
            Console.WriteLine("[Character.HP.get 호출]");
            return hp; 
        }
        set 
        { 
            Console.WriteLine($"[Character.HP.set 호출] {value}");
            if (value < 0) hp = 0;
            else hp = value;
        }
    }
    
    // virtual 메서드 (비교를 위해)
    public virtual void ShowHP()
    {
        Console.WriteLine($"[Character.ShowHP 호출] HP: {HP}");
    }
}

// 자식 클래스
class Warrior : Character
{
    // 프로퍼티 오버라이드 (vtable의 엔트리를 교체!)
    public override int HP
    {
        get 
        { 
            Console.WriteLine("[Warrior.HP.get 호출 - 방어력 보너스 적용]");
            return base.HP + 50;  // 전사는 HP에 방어력 보너스
        }
        set 
        { 
            Console.WriteLine($"[Warrior.HP.set 호출] {value} (전사 버전)");
            base.HP = value;
        }
    }
    
    // 메서드 오버라이드
    public override void ShowHP()
    {
        Console.WriteLine($"[Warrior.ShowHP 호출] ⚔️ 전사 HP: {HP}");
    }
}

class Mage : Character
{
    // 프로퍼티 오버라이드
    public override int HP
    {
        get 
        { 
            Console.WriteLine("[Mage.HP.get 호출 - 마나 실드 적용]");
            return base.HP * 2;  // 마법사는 마나 실드로 2배
        }
        set 
        { 
            Console.WriteLine($"[Mage.HP.set 호출] {value} (마법사 버전)");
            base.HP = value / 2;  // 실제 HP는 절반만 저장
        }
    }
    
    public override void ShowHP()
    {
        Console.WriteLine($"[Mage.ShowHP 호출] 🔮 마법사 HP: {HP}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("╔═══════════════════════════════════════════╗");
        Console.WriteLine("║   Virtual 프로퍼티와 가상 함수 테이블   ║");
        Console.WriteLine("╚═══════════════════════════════════════════╝\n");
        
        // ========== 1. 다형성 테스트 ==========
        Console.WriteLine("【 1. 다형성 (Polymorphism) 】\n");
        
        Character[] party = new Character[3];
        party[0] = new Character();
        party[1] = new Warrior();
        party[2] = new Mage();
        
        Console.WriteLine("=== HP 설정 (set 접근자 호출) ===\n");
        
        for (int i = 0; i < party.Length; i++)
        {
            Console.WriteLine($"캐릭터 {i + 1}:");
            party[i].HP = 100;  // 각 클래스의 set 접근자 호출!
            Console.WriteLine();
        }
        
        Console.WriteLine("=== HP 읽기 (get 접근자 호출) ===\n");
        
        for (int i = 0; i < party.Length; i++)
        {
            Console.WriteLine($"캐릭터 {i + 1}:");
            int currentHP = party[i].HP;  // 각 클래스의 get 접근자 호출!
            Console.WriteLine($"결과값: {currentHP}\n");
        }
        
        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");
        
        // ========== 2. 메서드와 프로퍼티 비교 ==========
        Console.WriteLine("【 2. 메서드 vs 프로퍼티 오버라이드 】\n");
        
        Character warrior = new Warrior();
        
        Console.WriteLine("메서드 호출:");
        warrior.ShowHP();
        
        Console.WriteLine("\n프로퍼티 접근:");
        Console.WriteLine($"HP 값: {warrior.HP}");
        
        Console.WriteLine("\n━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");
        
        // ========== 3. vtable 동작 확인 ==========
        Console.WriteLine("【 3. 런타임 타입에 따른 동작 】\n");
        
        Character baseRef;
        
        Console.WriteLine("▶ Character 타입으로 Warrior 참조:");
        baseRef = new Warrior();
        baseRef.HP = 50;
        Console.WriteLine($"읽은 값: {baseRef.HP}");
        
        Console.WriteLine("\n▶ Character 타입으로 Mage 참조:");
        baseRef = new Mage();
        baseRef.HP = 50;
        Console.WriteLine($"읽은 값: {baseRef.HP}");
        
        Console.WriteLine("\n━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");
        
        // ========== 4. get과 set을 각각 오버라이드 ==========
        Console.WriteLine("【 4. get/set 개별 오버라이드 】\n");
        
        PartialOverride po = new PartialOverride();
        
        //Console.WriteLine("set 호출:");
        //po.PartialProp = 100;
        
        //Console.WriteLine("\nget 호출:");
        //Console.WriteLine($"값: {po.PartialProp}");
    }
}

// get만 오버라이드하는 예제
class PartialOverride : Character
{
    // get만 오버라이드 (set은 부모 클래스 사용)
    public override int HP
    {
        get
        {
            Console.WriteLine("[PartialOverride.HP.get] - 10배 반환");
            return base.HP * 10;
        }
        set => base.HP = value;
    }
}