using McSkin;

// retrieve a player skin
using var skin = await SkinGrabber.FromUsername("PotatoMaster101");

// retrieve a section on the skin
var section = SkinSectionCollection.Get(SkinSectionId.Head);
using var head = skin.GetSection(section);

// copy a section to another skin
using var skin2 = await SkinGrabber.FromUsername("MHF_Pig");
skin.CopySectionTo(section, skin2);

// save a skin
await skin2.Save("output.png");
