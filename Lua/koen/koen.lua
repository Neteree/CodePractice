local Koen_csv = require("koen_csv")
local word_pairs = Koen_csv.to_word_pairs()

for i = 1, #word_pairs do
  print(word_pairs[i].ko, word_pairs[i].en)
end
