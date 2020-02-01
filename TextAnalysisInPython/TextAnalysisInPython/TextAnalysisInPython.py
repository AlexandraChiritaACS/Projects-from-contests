#text = "This warning shouldn't be taken lightly."
#print(text.split(sep=" "))
# we can also use text.split() which by default uses space as delimiter
#import regex as re
#clean_text = re.sub(r"\p{P}+", "", text)
#print(clean_text.split())

#import nltk
#import spacy
#from spacy.lang.en import English
#import spacy
#from spacy import displacy
#from collections import Counter
#English.
#nlp = English.load()
#doc = English(text)
#print([token.text for token in doc])

import spacy
from spacy.lang.en.examples import sentences 

nlp = spacy.load('en_core_web_sm')
doc = nlp(sentences[0])
print(doc.text)
for token in doc:
    print(token.text, token.pos_, token.dep_)