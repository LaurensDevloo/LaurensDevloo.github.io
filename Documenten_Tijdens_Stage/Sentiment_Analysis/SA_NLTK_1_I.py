import  nltk
from nltk.corpus import treebank

def download ():
    l = ['punkt', 'averaged_perceptron_tagger', 'maxent_ne_chunker', 'words', 'treebank']

    for i in l:
        nltk.download(i)

download()

sentence = "At eigh o'clock on Thursday morning Artur didn't feel very good."

tokens = nltk.word_tokenize(sentence)
print(tokens)

tagged = nltk.pos_tag(tokens)
print(tagged[0:6])

entities = nltk.chunk.ne_chunk(tagged)
print(entities)

t = treebank.parsed_sents('wsj_0001.mrg')[0]

t.draw()