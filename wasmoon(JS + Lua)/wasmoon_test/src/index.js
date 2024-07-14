(async function () {
  const { LuaFactory } = require("wasmoon");

  const factory = new LuaFactory();
  const lua = await factory.createEngine();

  try {
    function createElementOnBody(name, content) {
      const element = document.createElement(name);
      element.textContent = content;
      document.body.appendChild(element);
    }
    
    lua.global.set("create_element_on_body", createElementOnBody);

    await lua.doString(`
      word_pairs = {
        {ko = "안녕", en = "hi"},
        {ko = "네", en = "yes"},
        {ko = "아니요", en = "no"},
        {ko = "사랑", en = "love"},
        {ko = "케이팝", en = "k-pop"},
      }

      function create_word_pairs_on_body()
        for i = 1, #word_pairs do
          create_element_on_body("p", word_pairs[i].ko .. " : " .. word_pairs[i].en)
        end
      end
    `);

    createWordPairsOnBody = lua.global.get("create_word_pairs_on_body");
    createWordPairsOnBody();
  } finally {
    lua.global.close();
  }
})();
