M = {}

function M.to_word_pairs()
  local word_pairs = {}

  for line in io.lines("koen.csv") do
    local ko, en = line:match("%s*(.-),%s*(.*)")
    table.insert(word_pairs, {ko = ko, en = en})
  end

  return word_pairs
end

return M
