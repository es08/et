using eTracking.Model;
using eTracking.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eTracking.DAL
{
    public static class DbInitializer
    {
        public static void Initialize(ETrackingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any data.
            if (context.Majors.Any())
            {
                return;   //DB has been seeded
            }

            var majors = new Major[]
            {
                new Major{Name_TH="เทคโนโลยีสารสนเทศ", Name_EN="Information Technology", Abbreviation="IT", Active=ActiveStatus.Active, Created=DateTime.Now},
                new Major{Name_TH="วิทยาการคอมพิวเตอร์", Name_EN="Computer Science", Abbreviation="CS", Active=ActiveStatus.Active, Created=DateTime.Now},
                new Major{Name_TH="วิศวกรรมซอฟต์แวร์", Name_EN="Software Engineering", Abbreviation="SE", Active=ActiveStatus.Active, Created=DateTime.Now},
                new Major{Name_TH="เทคโนโลยีมัลติมีเดียและการสร้างภาพเคลื่อนไหว", Name_EN="Multimedia Technology and Animation", Abbreviation="MTA", Active=ActiveStatus.Active, Created=DateTime.Now},
                new Major{Name_TH="วิศวกรรมคอมพิวเตอร์", Name_EN="Computer Engineering", Abbreviation="CE", Active=ActiveStatus.Active, Created=DateTime.Now},
                new Major{Name_TH="วิศวกรรมการสื่อสารและสารสนเทศ", Name_EN="Information and Communication Engineering", Abbreviation="ICE", Active=ActiveStatus.Active, Created=DateTime.Now},
                new Major{Name_TH="อื่นๆ", Name_EN="ECT", Abbreviation="ECT", Active=ActiveStatus.Active, Created=DateTime.Now},
            };

            foreach (Major m in majors)
            {
                context.Majors.Add(m);
            }

            context.SaveChanges();

            var positions = new Position[]
            {
                new Position{Name_TH="อาจารย์", Name_EN="Lecturer", Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new Position{Name_TH="นักวิชาการคอมพิวเตอร์", Name_EN="Computer Technical Officer", Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new Position{Name_TH="เจ้าหน้าที่บริหาร", Name_EN="Administrative Officer", Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
            };

            foreach (Position p in positions)
            {
                context.Positions.Add(p);
            }

            context.SaveChanges();

            var staffs = new Staff[]
            {
                new Staff{ Code="49213064", Name_TH="อาจารย์ ดร.บรรพจณ์  โนแบ้ว", Name_EN="Dr. Banphot Nobaew", MajorID=7, Email="banphot@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="56213067", Name_TH="อาจารย์ นนทวรรษ  ธงสิบสอง", Name_EN="Mr. Nontawat Thongsibsong", MajorID=7, Email="nontawat@mfu.ac.th", Telephone="6748", Room="308", Active=ActiveStatus.Active, Phone="080-5111105", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="58213160", Name_TH="อาจารย์ รัชชานนท์ นอบนพ", Name_EN="Mr. Ratchanon Nobnop", MajorID=7, Email="ratchanon.nob@mfu.ac.th", Telephone="6748", Room="308", Active=ActiveStatus.Active, Phone="094-6011333", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="46213005", Name_TH="อาจารย์ พฤทธิ์ พุฒจร ", Name_EN="Mr. Pruet Putjorn", MajorID=7, Email="pruet@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="54219022", Name_TH="อาจารย์ ยุทธพงษ์ ทองแพง", Name_EN="Mr. Yootthapong Tongpaeng", MajorID=7, Email="", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="49213080", Name_TH="อาจารย์ ดร.วรศักดิ์ เรืองศิรรักษ์", Name_EN="Dr. Worasak Rueangsirarak", MajorID=7, Email="worasak.rue@mfu.ac.th", Telephone="6747", Room="308", Active=ActiveStatus.Active, Phone="088-5068384", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="56213081", Name_TH="อาจารย์ ดร.นิลุบล คุรุบรรเจิดจิต", Name_EN="Dr. Nilubon Kurubanjerdjit", MajorID=7, Email="nilubon.kur@mfu.ac.th", Telephone="6763", Room="306", Active=ActiveStatus.Active, Phone="090-3178495", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="44260016", Name_TH="รองศาสตรจารย์ น.อ. ยุทธนา ตระหง่าน", Name_EN="Assoc. Prof. Gp. Capt. Yutana Tra-ngan", MajorID=7, Email="yuthana-t@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="00000000", Name_TH="ไม่ระบุ", Name_EN="Unknown", MajorID=7, Email="", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="60213022", Name_TH="อาจารย์ ดร. ศุภกานต์ จันทร์เสรีวิทยา", Name_EN="Dr.Supakarn Chansareewittaya", MajorID=7, Email="suppakarn.cha@mfu.ac.th", Telephone="6756", Room="310", Active=ActiveStatus.Active, Phone="0817211158", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="54100138", Name_TH="รองศาสตราจาย์ ดร.ชยาพร วัฒนศิริ", Name_EN="Assoc. Prof. Dr. Chayaporn Wattanasiri", MajorID=7, Email="", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="50213106", Name_TH="อาจารย์ ขวัญตา  คีรีมาศทอง", Name_EN="Ms. Khwunta Kirimasthong", MajorID=7, Email="", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="48213133", Name_TH="อาจารย์ ดร.ปิยะศักดิ์ เจียตระกูล", Name_EN="Dr. Piyasak Jeatrakul", MajorID=7, Email="piyasak.jea@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="53213205", Name_TH="อาจารย์ วัชราวรรณ  อินทยศ", Name_EN="Ms. Wacharawan Intayoad", MajorID=7, Email="wacharawan.int@mfu.ac.th", Telephone="6764", Room="307", Active=ActiveStatus.Active, Phone="087-5524394", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="54213083", Name_TH="อาจารย์ เขมชาติ  เขมาวุฒานนท์", Name_EN="Mr. Kemachart Kemavuthanon", MajorID=7, Email="kemachart.kem@mfu.ac.th", Telephone="6748", Room="308", Active=ActiveStatus.Active, Phone="095-9394565", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="46360076", Name_TH="นาย สิทธิชัย แทนด้วง", Name_EN="Mr. Sittichai Tanduang", MajorID=7, Email="sittichai@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="49213039", Name_TH="อาจารย์ วราลักษณ์  ช่องดารากุล", Name_EN="Ms. Waralak Chongdarakul", MajorID=7, Email="", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="54213173", Name_TH="อาจารย์ พัชราภรณ์  พรรณวงค์", Name_EN="Ms. Patcharaporn Panwong", MajorID=7, Email="patcharaporn.pan@mfu.ac.th", Telephone="6763", Room="306", Active=ActiveStatus.Active, Phone="087-1748997", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="49213151", Name_TH="อาจารย์ นิกรณ์  หร่องบุตรศรี", Name_EN="Mr. Nikorn Rongbutsri", MajorID=7, Email="nikorn@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="50213140", Name_TH="อาจารย์ ดร.สุนทรินทร์ นุภาพ", Name_EN="Dr. Soontarin Nupap", MajorID=7, Email="soontarin@mfu.ac.th", Telephone="6762", Room="306", Active=ActiveStatus.Active, Phone="084-6107555", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="42213017", Name_TH="อาจารย์ ดร.สุรพงษ์  อุตมา", Name_EN="Dr. Surapong Uttama", MajorID=7, Email="surapong@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="48213001", Name_TH="ผู้ช่วยศาสตราจารย์ ดร.ณัฐกานต์  เอี่ยมอ่อน", Name_EN="Asst. Prof. Dr. Natthakan Iam-On", MajorID=7, Email="natthakan.iam@mfu.ac.th", Telephone="6763", Room="306", Active=ActiveStatus.Active, Phone="086-3419689", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="42213028", Name_TH="อาจารย์ เตือนจิต  สุทธหลวง", Name_EN="Ms. Teanjit Sutthaluang", MajorID=7, Email="ternchit@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="54213075", Name_TH="อาจารย์ ดร.ธีรวิศิฏฐ์  เลาหะเพ็ญแสง", Name_EN="Dr. Teeravisit  Laohapensaeng", MajorID=7, Email="teeravisit.lao@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="50213198", Name_TH="อาจารย์  ชยพล  คำยอด", Name_EN="Mr. Chayapol Kamyod", MajorID=7, Email="chayapol.kam@mfu.ac.th", Telephone="6746", Room="307", Active=ActiveStatus.Active, Phone="095-6790053", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="54213084", Name_TH="อาจารย์ ปวีณา สืบสมบัติ", Name_EN="Ms. Paweena Suebsombut", MajorID=7, Email="paweena.sue@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="55213120", Name_TH="อาจารย์ สุรพล  วรภัทราทร", Name_EN="Mr. Surapol Vorapatratorn", MajorID=7, Email="Surapol.vor@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="49213005", Name_TH="อาจารย์ ดร.เสกสรรค์  ใหลตระกูล", Name_EN="Dr. Seksan Laitrakun", MajorID=7, Email="seksan.lai@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="57213009", Name_TH="อาจารย์ ภัทรมน  วุฒิพิทยามงคล", Name_EN="Ms. Pattaramon Vuttipittayamongkol", MajorID=7, Email="pattaramon.vut@mfu.ac.th", Telephone="6762", Room="306", Active=ActiveStatus.Active, Phone="091-7933433", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="45213021", Name_TH="อาจารย์ ดร.ศิริกานต์  ชูเชิด", Name_EN="Dr. Sirikan Chucherd", MajorID=7, Email="sirikan@mfu.ac.th", Telephone="6763", Room="306", Active=ActiveStatus.Active, Phone="081-8867077", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="59213040", Name_TH="อาจารย์ Khaled  Kessali", Name_EN="Mr. Khaled  Kessali", MajorID=7, Email="", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="54213167", Name_TH="อาจารย์ ดร.ลักษณ์  เจริญวัฒนา ", Name_EN="Dr. Luck Charoenwatan", MajorID=7, Email="luck.cha@mfu.ac.th", Telephone="6762", Room="306", Active=ActiveStatus.Active, Phone="089-9251117", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="49213097", Name_TH="อาจารย์ ดร.สันติชัย  วิชา", Name_EN="Dr. Santichai Wicha", MajorID=7, Email="santichai@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="55213048", Name_TH="อาจารย์ ดร.ศิริชัย  เหมรุ่งโรจน์", Name_EN="Dr. Sirichai Hemrungrote", MajorID=7, Email="sirichai.hem@mfu.ac.th", Telephone="6746", Room="307", Active=ActiveStatus.Active, Phone="086-8688600", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="55213038", Name_TH="ผู้ช่วยศาสตราจารย์ ดร.รังสรรค์  ชัยศรีเจริญ", Name_EN="Asst. Prof. Dr. Roungsan Chaisricharoen", MajorID=7, Email="", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="45213081", Name_TH="ผู้ช่วยศาสตราจารย์ น.อ. ดร.ธงชัย  อยู่ญาติวงศ์", Name_EN="Asst. Prof. Gp. Capt. Dr.Thongchai Yooyatiwong", MajorID=7, Email="thongchai.mfu@gmail.com", Telephone="7200", Room="314/4", Active=ActiveStatus.Active, Phone="089-9982174", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="53213116", Name_TH="อาจารย์ ดร.ภาคภูมิ  บุญญานันต์", Name_EN="Dr. Phakphoom Boonyanant", MajorID=7, Email="phakphoom.boo@mfu.ac.th", Telephone="6764", Room="307", Active=ActiveStatus.Active, Phone="086-7744877", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="57213054", Name_TH="อาจารย์ ดร.ณัฐพล  อุ่นศรี", Name_EN="Dr. Nattapol Aunsri", MajorID=7, Email="nattapol.aun@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="49213048", Name_TH="ผู้ช่วยศาสตราจารย์ ดร.พรรณฤมล  เต็มดี", Name_EN="Asst. Prof. Dr. Punnarumol Temdee", MajorID=7, Email="punnarumol@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="51360043", Name_TH="นางสาว นาถธิชา เกษรพันธ์", Name_EN="Ms. Natticha Gasonpan", MajorID=7, Email="nattichagasonpan@gmail.com", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="49360043", Name_TH="ว่าที่ ร.ต. ฐาปกรณ์ ศศิวิมลลักษณ์", Name_EN="Acting Sub Lt. Thaprakorn Sasiwimolluk", MajorID=7, Email="", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="58313134", Name_TH="นางสาว ศิวพร บุญสมวล", Name_EN="Ms. Siwaporn Boonsamuan", MajorID=7, Email="kakarotsi29@gmail.com", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="58313139", Name_TH="นางสาว รจนา สุวรรณ", Name_EN="Ms. Rodjana Suwan", MajorID=7, Email="rodjana.suw@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="46313101", Name_TH="นางสาว พรทิพย์ ปัญญา", Name_EN="Ms. Porntip Panya", MajorID=7, Email="porntip.pan@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="44313004", Name_TH="นาง ศุภธิดา ธรรมสุทธิวัฒน์", Name_EN="Mrs. Supathida Thamsutiwat", MajorID=7, Email="supathida@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="51313002", Name_TH="นางสาว ทัตต์ชไม หวานชัยสีห์", Name_EN="Ms. Tatchamay Wahnchaishi", MajorID=7, Email="tatchamay.wah@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="54313192", Name_TH="นางสาว สยุมพร ไชยชมภู", Name_EN="Ms. Sayumporn Chaichompoo", MajorID=7, Email="sayumporn.cha@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="53313095", Name_TH="นางสาว รัตติกาล นางแล", Name_EN="Ms. Rattikan Nanglae", MajorID=7, Email="rattikan.nan@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="57213182", Name_TH="อาจารย์ ปรัสรา  จักรแก้ว", Name_EN="Ms. Prasara Jakkaew", MajorID=7, Email="prasara.jak@mfu.ac.th", Telephone="6764", Room="307", Active=ActiveStatus.Active, Phone="082-8719801", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="58213029", Name_TH="อาจารย์ ทิว  หงษ์ทอง", Name_EN="Mr. Tew Hongthong", MajorID=7, Email="tew.hon@mfu.ac.th", Telephone="6747", Room="308", Active=ActiveStatus.Active, Phone="087-7911251", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="54213103", Name_TH="อาจารย์ นชา ชลดำรงค์กุล  ", Name_EN="Mr. Nacha Choldomrongkul", MajorID=7, Email="nacha.cho@mfu.ac.th", Telephone="", Room="", Active=ActiveStatus.Active, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="49213047", Name_TH="อาจารย์ วิทยาศักดิ์  รุจิวรกุล", Name_EN="Mr. Vittayasak Rujivorakul", MajorID=7, Email="", Telephone="", Room="", Active=ActiveStatus.InActive, Phone="", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Staff{ Code="54318168", Name_TH="อาจารย์ ณรงค์ ชัยวุฒิ", Name_EN="Mr. Narong Chaiwut", MajorID=7, Email="narong.cha@mfu.ac.th", Telephone="6746", Room="307", Active=ActiveStatus.Active, Phone="082-6275688", PositionID=1, Created=DateTime.Now, Updated=DateTime.Now},
            };

            foreach (Staff s in staffs)
            {
                context.Staffs.Add(s);
            }

            context.SaveChanges();


            var projectstatus = new ProjectStatus[]
            {
                new ProjectStatus{Name_TH="ยังไม่ดำเนินการ", Name_EN="No action", Active=ActiveStatus.Active, Created=DateTime.Now},
                new ProjectStatus{Name_TH="กำลังดำเนินการ", Name_EN="In progress", Active=ActiveStatus.Active, Created=DateTime.Now},
                new ProjectStatus{Name_TH="เสร็จสิ้นโครงการ", Name_EN="Done", Active=ActiveStatus.Active, Created=DateTime.Now},
            };

            foreach (ProjectStatus p in projectstatus)
            {
                context.ProjectStatus.Add(p);
            }

            context.SaveChanges();

            var borrowingTypes = new BorrowingType[]
            {
                new BorrowingType{Name_TH="ไม่ระบุ", Name_EN="Unidentify", Created=DateTime.Now, Updated=DateTime.Now},
                new BorrowingType{Name_TH="ยืมเงินทดรอง", Name_EN="", Created=DateTime.Now, Updated=DateTime.Now},
                new BorrowingType{Name_TH="สำรองจ่าย", Name_EN="", Created=DateTime.Now, Updated=DateTime.Now},
                new BorrowingType{Name_TH="จ่ายทั่วไป", Name_EN="", Created=DateTime.Now, Updated=DateTime.Now},
                new BorrowingType{Name_TH="โอนมีเดีย", Name_EN="", Created=DateTime.Now, Updated=DateTime.Now},
            };

            foreach (BorrowingType b in borrowingTypes)
            {
                context.BorrowingTypes.Add(b);
            }

            context.SaveChanges();

            var workFlows = new WorkFlow[]
            {
                new WorkFlow{Name_TH="ยังไม่ดำเนินการ", Name_EN="", Sequence=1, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="รักษาการแทนคณบดี", Name_EN="", Sequence=7, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ส่วนจัดหางาน", Name_EN="", Sequence=3, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ส่วนพัสดุ", Name_EN="", Sequence=19, Active=0, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ส่วนการเจ้าหน้าที่", Name_EN="", Sequence=4, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ส่วนการเงินและบัญชี (ตัดงบ)", Name_EN="", Sequence=6, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="รองอธิการบดีในกำกับดูแล", Name_EN="", Sequence=8, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="อธิการบดีมหาวิทยาลัย", Name_EN="", Sequence=9, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ส่งการเงินทำเช็ค", Name_EN="", Sequence=10, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="รับเงินสด", Name_EN="", Sequence=11, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ส่ง Final Report", Name_EN="", Sequence=15, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ส่วนนโยบายและแผน", Name_EN="", Sequence=5, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="กำหนดวันคืนเงิน", Name_EN="", Sequence=13, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ส่งเอกสารสรุปค่าใช้จ่ายให้ส่วนการเงิน", Name_EN="", Sequence=16, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="จองโสตฯ", Name_EN="", Sequence=21, Active=0, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="จองรถรับ-ส่ง/เช่ารถตู้", Name_EN="", Sequence=22, Active=0, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="จองอาหาร/อาหารว่าง", Name_EN="", Sequence=23, Active=0, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="รายงานการเดินทางอาจารย์/วิทยากร", Name_EN="", Sequence=24, Active=0, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="รายงานการเดินทางนักศึกษา", Name_EN="", Sequence=25, Active=0, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="จัดทำใบรับรองการจ่ายเงิน", Name_EN="", Sequence=26, Active=0, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="จัดทำใบสำคัญรับเงิน", Name_EN="", Sequence=27, Active=0, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="จัดทำใบลงทะเบียน", Name_EN="", Sequence=28, Active=0, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ถ่ายเอกสาร", Name_EN="", Sequence=29, Active=0, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ส่งเอกสารการเงินตรวจใบเสร็จ", Name_EN="", Sequence=20, Active=0, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ส่งทรัพย์สิน/เรือนริมน้ำ/บ้านพัก", Name_EN="", Sequence=30, Active=0, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ดำเนินการแล้วเสร็จ", Name_EN="", Sequence=18, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="รับเช็ค", Name_EN="", Sequence=12, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ผู้ช่วยคณบดี/รักษาการแทนคณบดี", Name_EN="", Sequence=2, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="ส่วนการเงินออกใบฟ้า", Name_EN="", Sequence=14, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
                new WorkFlow{Name_TH="คืนเงินคงเหลือ", Name_EN="", Sequence=17, Active=ActiveStatus.Active, Created=DateTime.Now, Updated=DateTime.Now},
            };

            foreach (WorkFlow b in workFlows)
            {
                context.WorkFlows.Add(b);
            }

            context.SaveChanges();

            var projects = new Project[]
            {
                new Project{ Year=2560, Name_EN="IT บริหารจัดการสำนักวิชา", Name_TH="พัฒนาขั้นตอนการทำงานและพัมนาระบบ IT สำหรับการบริหารจัดการสำนักวิชา", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=45580.00, UsedAmount=0.00, Balance=45580.00, CreatorID=7, StatusID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="เครือข่ายพัฒนางานวิจัย", Name_TH="พัฒนางานวิจัยและสร้างเครือข่ายภายนอก", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=200000.00, UsedAmount=88700.00, Balance=111300.00, CreatorID=7, StatusID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="IT Community", Name_TH="การปรับแปลงนวัตกรรมทางด้าน ICT สู่หน่วยงานและชุมชน", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=60000.00, UsedAmount=0.00, Balance=60000.00, CreatorID=7, StatusID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="IT MAKER DAY", Name_TH="การแสดงผลงานและสัมมนาทางวิชาการด้าน IT และ Engineering โดยภาคอุตสาหกรรมและนักศึกษามหาวิทยาลัยแม่ฟ้าหลวง", StartDate=DateTime.Parse("Jan  1 2017 12:00AM"), EndDate=DateTime.Parse("Jan 31 2017 12:00AM"), Amount=200324.00, UsedAmount=92304.00, Balance=108020.00, CreatorID=7, StatusID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="ประชุมวิชาการ ป.ตรี", Name_TH="สนับสนุนนักศึกษาปริญญาตรีร่วมประชุมวิชาการระดับชาติและนานาชาติ", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=164400.00, UsedAmount=0.00, Balance=164400.00, CreatorID=7, StatusID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="แข่งขันวิชาการ Robot", Name_TH="สนับสนุนนักศึกษาเข้าร่วมแข่งขัน Robot Design Contest 2017 ที่เชียงใหม่", StartDate=DateTime.Parse("Jun  1 2017 12:00AM"), EndDate=DateTime.Parse("Jun 30 2017 12:00AM"), Amount=13550.00, UsedAmount=0.00, Balance=13550.00, CreatorID=7, StatusID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="แข่งขันวิชาการ ACM", Name_TH="แข่งขันทางวิชาการการเขียนโปรแกรมคอมพิวเตอร์ ACM-ICPC", StartDate=DateTime.Parse("Jul  1 2017 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=42500.00, UsedAmount=0.00, Balance=42500.00, CreatorID=7, StatusID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="TESA Top Gun Rally2017", Name_TH="การแข่งขันประชันทักษะทางด้านสมองกลฝังตัวชิงแชมป์ประเทศไทย ครั้งที่ 11", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Jan 31 2017 12:00AM"), Amount=58302.00, UsedAmount=0.00, Balance=58302.00, CreatorID=7, StatusID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="CS CAMP for Community", Name_TH="ค่ายคอมพิวเตอร์วิชาการเพื่อบริการวิชาการแก่ชุมชน สาขาวิทยาการคอมพิวเตอร์", StartDate=DateTime.Parse("Jun  1 2017 12:00AM"), EndDate=DateTime.Parse("Jul 31 2017 12:00AM"), Amount=39000.00, UsedAmount=36809.00, Balance=2191.00, CreatorID=7, StatusID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="แข่งขันทางวิชาการ NSC", Name_TH="แข่งขันทางวิชาการพัฒนาโปรแกรมคอมพิวเตอร์แห่งประเทศไทย", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=12000.00, UsedAmount=0.00, Balance=12000.00, CreatorID=7, StatusID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="โมเดล Smart City", Name_TH="สื่อการเรียนรู้ IoT ผ่านโมเดล Smart City", StartDate=DateTime.Parse("Feb  1 2017 12:00AM"), EndDate=DateTime.Parse("Apr 30 2017 12:00AM"), Amount=11000.00, UsedAmount=0.00, Balance=11000.00, CreatorID=7, StatusID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="แข่งขันวิชาการ Cabling", Name_TH="การแข่งขัน Cabling contest 4 (สุดยอดฝีมือสายสัญญาณปี 4)", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Oct 31 2016 12:00AM"), Amount=25524.00, UsedAmount=23387.00, Balance=2137.00, CreatorID=7, StatusID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="MFU Mobile Application", Name_TH="ส่งเสริมและอนุรักษ์ศิลปวัฒนธรรม MFU Mobile Application", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=20500.00, UsedAmount=0.00, Balance=20500.00, CreatorID=7, StatusID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="ทุนวิจัยค่างประเทศ", Name_TH="การสัมมนาเชิงปฏิบัติการเรื่อง \"ความร่วมมือด้านงานวิจัยและการขอทุนเพื่องานวิจัยต่างประเทศ\" (งบจากส่วนพัฒนาความสัมพันธ์ระหว่างประเทศ)", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Dec 31 2016 12:00AM"), Amount=71700.00, UsedAmount=0.00, Balance=71700.00, CreatorID=7, StatusID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="วท.ม. (เทคโนโลยีสารสนเทศ)", Name_TH="หลักสูตรวิทยาศาสตรมหาบัณฑิต สาขาวิชาเทคโนโลยีสารสนเทศ", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=226626.00, UsedAmount=116592.00, Balance=105634.00, CreatorID=7, StatusID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="วศ.ม. (วิศวกรรมคอมพิวเตอร์)", Name_TH="หลักสูตรวิศวกรรมศาสตรมหาบัณฑิต สาขาวิชาวิศวกรรมคอมพิวเตอร์ แผน ก1", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=226477.03, UsedAmount=75010.00, Balance=151467.03, CreatorID=7, StatusID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="ปร.ด. (วิศวกรรมคอมพิวเตอร์)", Name_TH="หลักสูตรปรัชญาดุษฎีบัณฑิต สาขาวิชาวิศวกรรมคอมพิวเตอร์", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=473869.10, UsedAmount=139443.10, Balance=330806.00, CreatorID=7, StatusID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="รับรองแขกและกิจกรรมสาธารณะ", Name_TH="ค่าใช้จ่ายในการรับรองแขกและกิจกรรมสาธารณะ", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=20000.00, UsedAmount=2000.00, Balance=18000.00, CreatorID=7, StatusID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="ประชุมกรรมการประจำสำนักวิชา", Name_TH="ค่าใช้จ่ายประชุมกรรมการประจำสำนักวิชา", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=48000.00, UsedAmount=0.00, Balance=48000.00, CreatorID=7, StatusID=1, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="ประเมินหลักสูตรครบวงรอบ", Name_TH="ค่าใช้จ่ายประเมินหลักสูตรครบวงรอบ", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=200000.00, UsedAmount=50370.40, Balance=139909.60, CreatorID=7, StatusID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="ประชาสัมพันธ์หลักสูตร ปริญญาตรี", Name_TH="ค่าใช้จ่ายประชาสัมพันธ์หลักสูตร ปริญญาตรี", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=50000.00, UsedAmount=46784.00, Balance=3216.00, CreatorID=7, StatusID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="ประชาสัมพันธ์หลักสูตร บัณฑิตศึกษา", Name_TH="ค่าใช้จ่ายประชาสัมพันธ์หลักสูตร บัณฑิตศึกษา", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=50000.00, UsedAmount=44730.10, Balance=1679.90, CreatorID=7, StatusID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="รับรางวัลการประกวดแบบตราสัญลักษณ์ (งบส่วนพัฒนานักศึกษา)", Name_TH="รับรางวัลการประกวดแบบตราสัญลักษณ์เนื่องในโอกาสครบรอบ 50 ปี บัณฑิตวิทยาลัย มหาวิทยาลัยเกษตรศาสตร์", StartDate=DateTime.Parse("Oct 10 2016 12:00AM"), EndDate=DateTime.Parse("Oct 10 2016 12:00AM"), Amount=2460.00, UsedAmount=2460.00, Balance=0.00, CreatorID=7, StatusID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="งบนักศึกษาช่วยงาน", Name_TH="ค่าตอบแทนนักศึกษาช่วยงาน ระดับปริญญาตรี (ส่วนจัดหางานและฝึกงานของนักศึกษา)", StartDate=DateTime.Parse("Oct  1 2016 12:00AM"), EndDate=DateTime.Parse("Sep 30 2017 12:00AM"), Amount=187000.00, UsedAmount=130120.00, Balance=56880.00, CreatorID=7, StatusID=2, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="ACM-ICPC ระดับประเทศ", Name_TH="การแข่งขันเขียนโปรแกรมคอมพิวเตอร์ประเทศไทย ACM-ICPC ระดับประเทศ",  StartDate=DateTime.Parse("Oct 17 2016 12:00AM"), EndDate=DateTime.Parse("Oct 18 2016 12:00AM"), Amount=6820.00, UsedAmount=6820.00, Balance=0.00, CreatorID=7, StatusID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="ทุนสนับสนุนนำเสนอผลงานวิชาการ (นางสาวกฤติกา กันทวงค์)", Name_TH="ทุนสนับสนุนนำเสนอผลงานวิชาการ ทุนกระทรวงวิทยาศาสตร์ฯ ระดับปริญญาเอก", StartDate=DateTime.Parse("Dec 16 2016 12:00AM"), EndDate=DateTime.Parse("Dec 30 2016 12:00AM"), Amount=182100.00, UsedAmount=182100.00, Balance=0.00, CreatorID=7, StatusID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="วิทยากรบรรยายพิเศษในรายวิชา 1/2559", Name_TH="โครงการวิทยากรบรรยายพิเศษในรายวิชา ภาคการศึกษาต้น ปีการศึกษา 2559", StartDate=DateTime.Parse("Aug  8 2016 12:00AM"), EndDate=DateTime.Parse("Dec  3 2016 12:00AM"), Amount=201600.00, UsedAmount=94060.00, Balance=106740.00, CreatorID=6, StatusID=3, Created=DateTime.Now, Updated=DateTime.Now},
                new Project{ Year=2560, Name_EN="วิทยากรบรรยายพิเศษในรายวิชา 2/2559", Name_TH="โครงการวิทยากรบรรยายพิเศษในรายวิชา ภาคการศึกษาต้น ปีการศึกษา 2559", StartDate=DateTime.Parse("Jan  9 2017 12:00AM"), EndDate=DateTime.Parse("May  7 2017 12:00AM"), Amount=218400.00, UsedAmount=0.00, Balance=218400.00, CreatorID=6, StatusID=1, Created=DateTime.Now, Updated=DateTime.Now},
            };

            foreach (Project p in projects)
            {
                p.ProjectStaffs.Clear();
                p.ProjectStaffs = randomStaffs(context, p);
                context.Projects.Add(p);
            }

            context.SaveChanges();

            var activites = new Activity[]
            {
                new Activity{ ProjectID=10, BorrowingTypeID=1, CreatorID=7, ActivatorID=7, Name_EN="", Name_TH="ค่ารับรองวิทยากรอบรมพัฒนาทักษะด้าน Cabling เพื่อเตรียมความพร้อมก่อนการแข่งขัน “Cabling Contest” ครั้งที่ 4 (สุดยอดฝีมือสายสัญญาณปี 4) รอบคัดเลือกระดับภูมิภาค", FilePath= "", StartDate=DateTime.Parse("2016-10-18"), EndDate=DateTime.Parse("2016-10-18"), Amount=2000.00, UsedAmount=2000.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=5, BorrowingTypeID=1, CreatorID=7, ActivatorID=15, Name_EN="", Name_TH="รับรางวัลการประกวดแบบตราสัญลักษณ์เนื่องในโอกาสครบรอบ 50 ปี บัณฑิตวิทยาลัย มหาวิทยาลัยเกษตรศาสตร์", FilePath= "", StartDate=DateTime.Parse("2016-10-10"), EndDate=DateTime.Parse("2016-10-10"), Amount=2460.00, UsedAmount=2460.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=13, BorrowingTypeID=1, CreatorID=7, ActivatorID=15, Name_EN="", Name_TH="นำเสนอผลงานในที่ประชุมวิชาการ ACIS2016 (นางสาวมัลลิกา พัฒโนดม)", FilePath= "", StartDate=DateTime.Parse("2016-10-27"), EndDate=DateTime.Parse("2016-10-29"), Amount=13426.00, UsedAmount=13426.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=13, BorrowingTypeID=1, CreatorID=7, ActivatorID=15, Name_EN="", Name_TH="นำเสนอผลงานในที่ประชุมวิชาการ ISPACS2016 (ศิวพร บุญสมวล)", FilePath= "", StartDate=DateTime.Parse("2016-10-24"), EndDate=DateTime.Parse("2016-10-27"), Amount=12000.00, UsedAmount=12000.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=12, BorrowingTypeID=1, CreatorID=7, ActivatorID=15, Name_EN="", Name_TH="นำเสนอผลงานในที่ประชุมวิชาการ ISPACS2016 (คธาวุธ, Roman)", FilePath= "", StartDate=DateTime.Parse("2016-10-24"), EndDate=DateTime.Parse("2016-10-27"), Amount=12277.00, UsedAmount=12277.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=12, BorrowingTypeID=1, CreatorID=7, ActivatorID=15, Name_EN="", Name_TH="โครงการบรรยายพิเศษ เรื่อง “การประมวลผลข้อมูลและองค์ความรู้ขนาดใหญ่” (สำรองจ่าย)", FilePath= "", StartDate=DateTime.Parse("2016-10-05"), EndDate=DateTime.Parse("2016-10-05"), Amount=15928.00, UsedAmount=15928.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=13, BorrowingTypeID=1, CreatorID=7, ActivatorID=51, Name_EN="", Name_TH="นำเสนอผลงานในที่ประชุมวิชาการ The 14th International Conference on ICT and Knowledge Engineering 2016 (ดนัย สายสงวนสัตย์)", FilePath= "", StartDate=DateTime.Parse("2016-11-23"), EndDate=DateTime.Parse("2016-11-25"), Amount=20000.00, UsedAmount=18100.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=16, BorrowingTypeID=1, CreatorID=7, ActivatorID=25, Name_EN="", Name_TH="โครงการแข่งขัน Cabling Contest ครั้งที่ 4 รอบคัดเลือกระดับภูมิภาค", FilePath= "", StartDate=DateTime.Parse("2016-10-20"), EndDate=DateTime.Parse("2016-10-21"), Amount=8150.00, UsedAmount=8150.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=19, BorrowingTypeID=1, CreatorID=7, ActivatorID=12, Name_EN="", Name_TH="CS Camp for Cummunity", FilePath= "", StartDate=DateTime.Parse("2016-11-19"), EndDate=DateTime.Parse("2016-11-20"), Amount=39000.00, UsedAmount=36809.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=16, BorrowingTypeID=1, CreatorID=7, ActivatorID=25, Name_EN="", Name_TH="โครงการอบรมพัฒนาทักษะด้าน Cabling เพื่อเตรียมความพร้อมก่อนการแข่งขัน Cabling Contest ครั้งที่ 4", FilePath= "", StartDate=DateTime.Parse("2016-10-18"), EndDate=DateTime.Parse("2016-10-18"), Amount=15237.00, UsedAmount=15237.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=13, BorrowingTypeID=1, CreatorID=7, ActivatorID=4, Name_EN="", Name_TH="สอบวิทยานิพนธ์ (นางสาวมัลลิกา พัฒโนดม)", FilePath= "", StartDate=DateTime.Parse("2016-11-18"), EndDate=DateTime.Parse("2016-11-18"), Amount=8540.00, UsedAmount=8540.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=4, BorrowingTypeID=1, CreatorID=7, ActivatorID=20, Name_EN="", Name_TH="ค่าจ้างนักศึกษาช่วยงานสำนักวิชาฯ (เดือน ตุลาคม 59)", FilePath= "", StartDate=DateTime.Parse("2016-10-01"), EndDate=DateTime.Parse("2016-10-31"), Amount=4350.00, UsedAmount=4350.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=6, BorrowingTypeID=1, CreatorID=7, ActivatorID=26, Name_EN="", Name_TH="ประชุมสัมมนาเกี่ยวกับหลักสูตรบัณฑิต ร่วมกับ มทล.ล้านนา วิทยาเขตน่าน", FilePath= "", StartDate=DateTime.Parse("2017-01-05"), EndDate=DateTime.Parse("2017-01-06"), Amount=18500.00, UsedAmount=14910.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=4, BorrowingTypeID=1, CreatorID=7, ActivatorID=20, Name_EN="", Name_TH="ค่าตอบแทนนักศึกษาช่วยงานรายวิชา Intro to IT", FilePath= "", StartDate=DateTime.Parse("2016-10-01"), EndDate=DateTime.Parse("2016-12-31"), Amount=30750.00, UsedAmount=30750.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=4, BorrowingTypeID=1, CreatorID=7, ActivatorID=20, Name_EN="", Name_TH="นักศึกษาช่วยงานสำนักวิชา (พฤศจิกายน 2559)", FilePath= "", StartDate=DateTime.Parse("2016-11-01"), EndDate=DateTime.Parse("2016-11-30"), Amount=7200.00, UsedAmount=7200.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=3, BorrowingTypeID=1, CreatorID=7, ActivatorID=15, Name_EN="", Name_TH="ค่าสนับสนุนนำเสนอผลงานวิชาการระดับนานาชาติ", FilePath= "", StartDate=DateTime.Parse("2016-12-16"), EndDate=DateTime.Parse("2016-12-30"), Amount=182100.00, UsedAmount=182100.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=11, BorrowingTypeID=1, CreatorID=7, ActivatorID=26, Name_EN="", Name_TH="นำเสนอผลงานในที่ประชุมวิชาการ GWS2016", FilePath= "", StartDate=DateTime.Parse("2016-11-27"), EndDate=DateTime.Parse("2016-11-30"), Amount=98695.00, UsedAmount=98695.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=13, BorrowingTypeID=1, CreatorID=7, ActivatorID=51, Name_EN="", Name_TH="นำเสนอผลงานในที่ประชุมวิชาการ ICSEC-2016 (นางสาวกัญจน์กมล ใจวัง)", FilePath= "", StartDate=DateTime.Parse("2016-12-14"), EndDate=DateTime.Parse("2016-12-17"), Amount=19274.00, UsedAmount=14874.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=13, BorrowingTypeID=1, CreatorID=7, ActivatorID=4, Name_EN="", Name_TH="ค่าตอบแทนอาจารย์ที่ปรึกษา และค่าตรวจรูปแบบการพิมพ์ (สไบทิพย์ บุญเป็ง)", FilePath= "", StartDate=DateTime.Parse("2016-12-21"), EndDate=DateTime.Parse("2016-12-21"), Amount=4700.00, UsedAmount=4700.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=4, BorrowingTypeID=1, CreatorID=7, ActivatorID=51, Name_EN="", Name_TH="นักศึกษาช่วยงานรายวิชา 2/2559 (ม.ค-พ.ค 59)", FilePath= "", StartDate=DateTime.Parse("2017-01-01"), EndDate=DateTime.Parse("2017-05-05"), Amount=22080.00, UsedAmount=0.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=4, BorrowingTypeID=1, CreatorID=7, ActivatorID=40, Name_EN="", Name_TH="นักศึกษาช่วยงานรายวิชา PBL 2/2559 (ม.ค-พ.ค.59)", FilePath= "", StartDate=DateTime.Parse("2017-01-09"), EndDate=DateTime.Parse("2017-05-05"), Amount=16320.00, UsedAmount=0.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=4, BorrowingTypeID=1, CreatorID=7, ActivatorID=51, Name_EN="", Name_TH="นักศึกษาช่วยงานในรายวิชา ภาคเรียนที่ 1/2559 (ตุลาคม-ธันวาคม59)", FilePath= "", StartDate=DateTime.Parse("2016-10-01"), EndDate=DateTime.Parse("2016-12-31"), Amount=15900.00, UsedAmount=15900.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=5, BorrowingTypeID=1, CreatorID=7, ActivatorID=26, Name_EN="", Name_TH="สร้างเครือข่ายงานวิจัยร่วมกับฟ้าประทาน ฟาร์ม", FilePath= "", StartDate=DateTime.Parse("2017-01-24"), EndDate=DateTime.Parse("2017-01-27"), Amount=45350.00, UsedAmount=44350.00, Balance=1000.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=24, BorrowingTypeID=1, CreatorID=7, ActivatorID=14, Name_EN="", Name_TH="ปรับปรุงหลักสูตรวิทยาศาสตรบัณฑิต สาขาวิชาวิทยาการคอมพิวเตอร์", FilePath= "", StartDate=DateTime.Parse("2017-01-31"), EndDate=DateTime.Parse("2017-02-01"), Amount=48800.00, UsedAmount=33010.40, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=4, BorrowingTypeID=1, CreatorID=7, ActivatorID=51, Name_EN="", Name_TH="นักศึกษาช่วยงานสำนักวิชา (ธันวาคม 2559)", FilePath= "", StartDate=DateTime.Parse("2016-12-01"), EndDate=DateTime.Parse("2016-12-31"), Amount=1800.00, UsedAmount=1800.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=4, BorrowingTypeID=1, CreatorID=7, ActivatorID=20, Name_EN="", Name_TH="นักศึกษาช่วยงานรายวิชา PBL 1/2559 (ต.ค.-ธ.ค.59)", FilePath= "", StartDate=DateTime.Parse("2016-10-01"), EndDate=DateTime.Parse("2016-12-31"), Amount=5550.00, UsedAmount=5500.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=24, BorrowingTypeID=1, CreatorID=6, ActivatorID=41, Name_EN="", Name_TH="โครงการจัดสัมมนาผู้ประกอบวิชาชีพทางด้าน ICT (Barcamp Chiang Rai 2017)", FilePath= "", StartDate=DateTime.Parse("2017-02-18"), EndDate=DateTime.Parse("2017-02-18"), Amount=50000.00, UsedAmount=46152.00, Balance=3848.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=12, BorrowingTypeID=1, CreatorID=7, ActivatorID=51, Name_EN="", Name_TH="ค่าตอบแทนที่ปรึกษาวิทยานิพนธ์ (นายธีรวัฒน์ ปันทะวงค์)", FilePath= "", StartDate=DateTime.Parse("2017-01-11"), EndDate=DateTime.Parse("2017-03-27"), Amount=4700.00, UsedAmount=0.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=24, BorrowingTypeID=1, CreatorID=7, ActivatorID=41, Name_EN="", Name_TH="ประชาสัมพันธ์ หลักสูตรวิทยาศาสตรบัณฑิต สาขวิชา SE+IT", FilePath= "", StartDate=DateTime.Parse("2017-02-10"), EndDate=DateTime.Parse("2017-03-09"), Amount=17000.00, UsedAmount=17000.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=12, BorrowingTypeID=1, CreatorID=7, ActivatorID=26, Name_EN="", Name_TH="ค่าตอบแทนที่ปรึกษาวิทยานิพนธ์ (นายณรงค์เดช หัตถกอง)", FilePath= "", StartDate=DateTime.Parse("2017-02-27"), EndDate=DateTime.Parse("2017-02-27"), Amount=4700.00, UsedAmount=4700.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=4, BorrowingTypeID=1, CreatorID=7, ActivatorID=20, Name_EN="", Name_TH="นักศึกษาช่วยงานรายวิชา PBL 1/2559 (ตุลาคม-ธันวาคม 59)", FilePath= "", StartDate=DateTime.Parse("2016-10-01"), EndDate=DateTime.Parse("2016-12-31"), Amount=5070.00, UsedAmount=5070.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=12, BorrowingTypeID=1, CreatorID=7, ActivatorID=26, Name_EN="", Name_TH="สอบโครงร่างวิทยานิพนธ์ (นายธีรเมธ แก้ววิเศษ)", FilePath= "", StartDate=DateTime.Parse("2017-02-25"), EndDate=DateTime.Parse("2017-02-25"), Amount=4350.00, UsedAmount=4350.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=4, BorrowingTypeID=1, CreatorID=7, ActivatorID=51, Name_EN="", Name_TH="นักศึกษาช่วยงานสำนักวิชาฯ เดือนกุมภาพันธ์ 2560", FilePath= "", StartDate=DateTime.Parse("2017-02-01"), EndDate=DateTime.Parse("2017-02-28"), Amount=3600.00, UsedAmount=2700.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=12, BorrowingTypeID=1, CreatorID=7, ActivatorID=30, Name_EN="", Name_TH="สอบโครงร่างวิทยานิพนธ์ (นางสาวสุพรรษา ไชยสิงห์)", FilePath= "", StartDate=DateTime.Parse("2017-02-25"), EndDate=DateTime.Parse("2017-02-25"), Amount=5200.00, UsedAmount=5200.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=24, BorrowingTypeID=1, CreatorID=7, ActivatorID=19, Name_EN="", Name_TH="ประชาสัมพันธ์ หลักสูตรวิทยาศาสตรบัณฑิต สาขวิชา ICE", FilePath= "", StartDate=DateTime.Parse("2017-02-13"), EndDate=DateTime.Parse("2017-02-28"), Amount=3200.00, UsedAmount=2540.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=6, BorrowingTypeID=1, CreatorID=7, ActivatorID=51, Name_EN="", Name_TH="นักศึกษาช่วยงานสำนักวิชาฯ เดือนมกราคม 2560", FilePath= "", StartDate=DateTime.Parse("2017-01-01"), EndDate=DateTime.Parse("2017-01-31"), Amount=3000.00, UsedAmount=3000.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=6, BorrowingTypeID=1, CreatorID=7, ActivatorID=14, Name_EN="", Name_TH="ประชาสัมพันธ์ หลักสูตรวิทยาศาสตรบัณฑิต สาขวิชา CS", FilePath= "", StartDate=DateTime.Parse("2017-01-02"), EndDate=DateTime.Parse("2017-02-17"), Amount=16900.00, UsedAmount=16900.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=6, BorrowingTypeID=1, CreatorID=7, ActivatorID=45, Name_EN="", Name_TH="ประชาสัมพันธ์ หลักสูตรวิทยาศาสตรบัณฑิต สาขวิชา MTA", FilePath= "", StartDate=DateTime.Parse("2017-02-01"), EndDate=DateTime.Parse("2017-02-28"), Amount=7700.00, UsedAmount=7700.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=6, BorrowingTypeID=1, CreatorID=7, ActivatorID=53, Name_EN="", Name_TH="ประชาสัมพันธ์ หลักสูตรวิทยาศาสตรบัณฑิต สาขวิชา CE", FilePath= "", StartDate=DateTime.Parse("2017-01-01"), EndDate=DateTime.Parse("2017-02-17"), Amount=2400.00, UsedAmount=1080.00, Balance=1320.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=11, BorrowingTypeID=1, CreatorID=7, ActivatorID=30, Name_EN="", Name_TH="สอบโครงร่างดุษฎีนิพนธ์ (5771501004 นายสถาวร ใจจุมปา)", FilePath= "", StartDate=DateTime.Parse("2017-02-25"), EndDate=DateTime.Parse("2017-02-25"), Amount=14150.00, UsedAmount=9130.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=8, BorrowingTypeID=1, CreatorID=7, ActivatorID=19, Name_EN="", Name_TH="ปรับปรุงหลักสูตรวิศวกรรมศาสตรบัณฑิต สาขาวิชาวิศวกรรมการสื่อสารและสารสนเทศ", FilePath= "", StartDate=DateTime.Parse("2017-02-03"), EndDate=DateTime.Parse("2017-02-03"), Amount=27080.00, UsedAmount=17360.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=1, BorrowingTypeID=1, CreatorID=7, ActivatorID=26, Name_EN="", Name_TH="เข้าร่วมนำเสนอผลงานในที่ประชุมวิชาการนานาชาติ ICDAMT2017", FilePath= "", StartDate=DateTime.Parse("2017-02-01"), EndDate=DateTime.Parse("2017-03-04"), Amount=35238.10, UsedAmount=31618.10, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=4, BorrowingTypeID=1, CreatorID=7, ActivatorID=51, Name_EN="", Name_TH="นักศึกษาช่วยงานสำนักวิชาฯ เดือน มีนาคม 2560", FilePath= "", StartDate=DateTime.Parse("2017-03-01"), EndDate=DateTime.Parse("2017-03-31"), Amount=3900.00, UsedAmount=0.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=18, BorrowingTypeID=1, CreatorID=7, ActivatorID=51, Name_EN="", Name_TH="โครงการแข่งขัน “Thailand’s Network Security Contest 2017 ครั้งที่ 10” ", FilePath= "", StartDate=DateTime.Parse("2017-03-11"), EndDate=DateTime.Parse("2017-03-11"), Amount=11250.00, UsedAmount=0.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=7, BorrowingTypeID=1, CreatorID=7, ActivatorID=14, Name_EN="", Name_TH="ประชาสัมพันธ์ หลักสูตรวิทยาศาสตรบัณฑิต สาขวิชา CS (เพิ่มเติม)", FilePath= "", StartDate=DateTime.Parse("2017-02-01"), EndDate=DateTime.Parse("2017-02-28"), Amount=242.00, UsedAmount=242.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=2, BorrowingTypeID=2, CreatorID=6, ActivatorID=51, Name_EN="", Name_TH="รายวิชา 1305392", FilePath= "", StartDate=DateTime.Parse("2016-11-05"), EndDate=DateTime.Parse("2016-11-05"), Amount=15200.00, UsedAmount=13200.00, Balance=2000.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=2, BorrowingTypeID=2, CreatorID=6, ActivatorID=51, Name_EN="", Name_TH="รายวิชา 1306217", FilePath= "", StartDate=DateTime.Parse("2016-11-07"), EndDate=DateTime.Parse("2016-11-09"), Amount=14050.00, UsedAmount=13360.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=2, BorrowingTypeID=2, CreatorID=6, ActivatorID=19, Name_EN="", Name_TH="รายวิชา 1502302", FilePath= "", StartDate=DateTime.Parse("2016-11-12"), EndDate=DateTime.Parse("2016-11-13"), Amount=15200.00, UsedAmount=14400.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=2, BorrowingTypeID=2, CreatorID=6, ActivatorID=14, Name_EN="", Name_TH="รายวิชา 1302392", FilePath= "", StartDate=DateTime.Parse("2016-11-12"), EndDate=DateTime.Parse("2016-11-13"), Amount=16600.00, UsedAmount=16300.00, Balance=300.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=2, BorrowingTypeID=2, CreatorID=6, ActivatorID=26, Name_EN="", Name_TH="รายวิชา 1501484", FilePath= "", StartDate=DateTime.Parse("2016-11-19"), EndDate=DateTime.Parse("2016-11-19"), Amount=16800.00, UsedAmount=14985.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=2, BorrowingTypeID=2, CreatorID=6, ActivatorID=41, Name_EN="", Name_TH="รายวิชา 1305493", FilePath= "", StartDate=DateTime.Parse("2016-11-21"), EndDate=DateTime.Parse("2016-11-21"), Amount=12000.00, UsedAmount=9015.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=2, BorrowingTypeID=2, CreatorID=6, ActivatorID=25, Name_EN="", Name_TH="รายวิชา 1502331", FilePath= "", StartDate=DateTime.Parse("2016-11-20"), EndDate=DateTime.Parse("2016-11-20"), Amount=6400.00, UsedAmount=6400.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
                new Activity{ ProjectID=2, BorrowingTypeID=2, CreatorID=6, ActivatorID=6, Name_EN="", Name_TH="รายวิชา 1301318", FilePath= "", StartDate=DateTime.Parse("0023-11-24"), EndDate=DateTime.Parse("0023-11-24"), Amount=7200.00, UsedAmount=6400.00, Balance=0.00, Created=DateTime.Now, Updated=DateTime.Now},
            };

            foreach (Activity p in activites)
            {
                p.WorkFlows.Clear();
                p.WorkFlows = randomWorkFlows(context, p);
                context.Activities.Add(p);
            }

            context.SaveChanges();
        }
        private static List<Activity_WorkFlow> randomWorkFlows(ETrackingContext context, Activity p)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 5);
            var wfs = new List<Activity_WorkFlow>();
            for (int i = 1; i <= number; i++)
            {
                int ids = rnd.Next(1, 30);
                if (wfs.FirstOrDefault(x => x.WorkFlowID == ids) == null)
                {
                    var wf = new Activity_WorkFlow()
                    {
                        Activity = p,
                        WorkFlow = context.WorkFlows.Find(ids),
                        WorkFlowID = ids,
                    };

                    wfs.Add(wf);
                }
            }

            return wfs.OrderBy(x => x.WorkFlow.Sequence).ToList<Activity_WorkFlow>();
        }

        private static List<Project_Staff> randomStaffs(ETrackingContext context, Project p)
        {
            Random rnd = new Random();
            int staffsNumber = rnd.Next(1, 5);
            var projectStaffs = new List<Project_Staff>();
            for (int i = 1; i <= staffsNumber; i++)
            {
                int staffIds = rnd.Next(1, 53);
                if (projectStaffs.FirstOrDefault(x => x.StaffID == staffIds) == null)
                {
                    var projectStaff = new Project_Staff()
                    {
                        Staff = context.Staffs.Find(staffIds),
                        Project = p,
                        Percentage = 100 / staffsNumber,
                    };

                    projectStaffs.Add(projectStaff);
                }

            }

            return projectStaffs;
        }
    }
}
